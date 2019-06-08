using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour {


    public static bool isAttacking;
    private Vector3 position;
    private float moveSpeed;
    public CharacterController controller;
    public AnimationClip run;
    public AnimationClip idle;
    public Animation anim;


	// Use this for initialization
	void Start () {
        position = transform.position;
        controller = this.GetComponent<CharacterController>();
        anim = this.GetComponent<Animation>();
        this.moveSpeed = this.GetComponent<Fighter>().moveSpeed;
        

    }

    // Update is called once per frame
    void Update () {

        if (!isAttacking)
        {
            if (Input.GetMouseButton(0))
            {
                locatePosition();


            }
            moveToPosition();
        }
        moveSpeed = this.GetComponent<Fighter>().moveSpeed;
	}

    void locatePosition() {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1000))
        {
            if (hit.collider.tag != "Player" && hit.collider.tag != "Enemy")
            {
                position = new Vector3(hit.point.x, hit.point.y, hit.point.z);
            }

        }

    }

    void moveToPosition()
    {
        //game object is moving
        if (Vector3.Distance(transform.position, position) > 1.5)
        {
            
            Quaternion newRotation = Quaternion.LookRotation(position - transform.position);
            newRotation.x = 0f;
            newRotation.z = 0f;
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 10);
            controller.SimpleMove(transform.forward * moveSpeed);
            anim.CrossFade(run.name);


        }
        else
        { //gameobject is not moving
            anim.CrossFade(idle.name);
        }
    }
}
