using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{

    public GameObject player;
    public Texture2D frame;
    public Rect framePosition;

    public Texture2D healthBar;
    public Texture2D healthLost;
    public Rect healthBarPos;

    public GameObject target;
    public float healthPercentage;
    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");



    }

    // Update is called once per frame
    void Update()
    {


        target = player.GetComponent<Player>().opponent;

        if (player.GetComponent<Player>().opponent != null)
        {
            healthPercentage = target.GetComponent<Enemy>().currentHealth / target.GetComponent<Enemy>().totalHealth;
        }
        else
        {
            target = null;
            healthPercentage = 0;
        }

    }

    void drawFrame()
    {
        framePosition.x = (Screen.width - framePosition.width) / 2;
        framePosition.width = Screen.width * 0.46f;
        framePosition.height = Screen.height * 0.097f;
        GUI.DrawTexture(framePosition, frame);

    }

    private void drawBar()
    {

        healthBarPos.x = (Screen.width - healthBarPos.width) / 2;
        healthBarPos.width = Screen.width * 0.46f * healthPercentage;
        healthBarPos.height = Screen.height * 0.097f;
        GUI.DrawTexture(healthBarPos, healthLost);
        GUI.DrawTexture(healthBarPos, healthBar);


    }
    private void OnGUI()
    {        

        
        // framePosition.y = 200;
        if (target != null && player.GetComponent<Player>().countDown > 0)
        {
            drawFrame();
            drawBar();
           }




    }
}
