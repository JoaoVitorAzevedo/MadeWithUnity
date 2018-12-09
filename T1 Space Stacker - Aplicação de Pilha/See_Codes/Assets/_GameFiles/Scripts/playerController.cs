using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BoundaryOrLimits{



    public float xMin, xMax, zMin, zMax;



}
public class playerController : MonoBehaviour {

    Rigidbody rigid;
    private AudioSource audi;

    Vector3 movement;
    public float movementSpeed;
    public BoundaryOrLimits boundaryRef;
    public float tilt;

    public GameObject bullet;
    public GameObject shotSpawnn;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
        audi = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, shotSpawnn.transform.position,
                shotSpawnn.transform.rotation);
            //GameObject clone = Instantiate(bullet, 
            //shotSpawnn.transform.position,
            // shotSpawnn.transform.rotation) as GameObject;

            audi.Play(); 
        }
	}

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);


        rigid.velocity = movement * movementSpeed;

        rigid.position = new Vector3(Mathf.Clamp(rigid.position.x,boundaryRef.xMin,boundaryRef.xMax) ,
            0.0f, Mathf.Clamp(rigid.position.z,boundaryRef.zMin,boundaryRef.zMax));

        rigid.rotation = Quaternion.Euler(0.0f,0.0f,rigid.velocity.x * -tilt);
        
    }
}
