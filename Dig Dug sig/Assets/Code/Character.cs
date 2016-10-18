using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Character : MonoBehaviour {

    public float speed = 5.5f;
    public CameraTrack follow;

    public static string direction = "";
    public static float playerx;
    public static float playery;

    public int distanceSpawn;
    public int health = 3;
    public int damageMod = 1;
    public int TNT=3;
    public int Dash=3;
    public int Biomatter=3;

    public Stopwatch Timer;
    public static double time;
    public static int fogEnd = 0;
    public static int acidEnd = 0;

    public GameObject PlayerFog;
    private Renderer FogRender;
    GameObject explosion;

    public Vector2 swipe = new Vector2();

    // Use this for initialization
    void Start ()
    {
        Timer = new Stopwatch();
        Timer.Start();
        time = 0;
        PlayerFog = GameObject.FindGameObjectWithTag("DirtBaby");
        FogRender = PlayerFog.GetComponent<Renderer>();
        FogRender.enabled = false;
        explosion = GameObject.FindGameObjectWithTag("DirtBaby");
        //Give TNT for testing purposes
        TNT = 1;
    }

	// Update is called once per frame
	void Update ()
    {
        time = Timer.Elapsed.TotalSeconds;
        playerx = transform.position.x;
        playery = transform.position.y;

        //if (Input.GetKey(KeyCode.LeftArrow) && direction != "Right")
        //{
        //    direction = "Left";
        //}
        //else if (Input.GetKey(KeyCode.RightArrow) && direction != "Left")
        //{
        //    direction = "Right";
        //}
        //else if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    direction = "Down";
        //}
        if (Input.touchCount > 0)
        {
            swipe = Input.GetTouch(0).deltaPosition;
            if (Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y)+10)
            {
                if (swipe.x > 5)
                {
                    direction = "Right";
                }
                else if (swipe.x < -5)
                {
                    direction = "Left";
                }
            }
            else if (Mathf.Abs(swipe.y)+10 > Mathf.Abs(swipe.x))
            {
                if (swipe.y < -5)
                {
                    direction = "Down";
                }
            }
        }

        //Move spawn stuff to main gamelogic script and make actual spawning stuff
        //if (Random.Range(0.0f, 1.0f) >= 0.95f)
        //{
        //    spawnPickup();
        //}

        if (direction == "Down")
        {
            // transform.position += Vector3.down * speed * Time.deltaTime;
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        else if (direction == "Left")
        {
            if (transform.position.x > -20)
            {
                transform.Translate(new Vector3(-1,0,0) * Time.deltaTime * speed);
            }
        }
        else if (direction == "Right")
        {
            if (transform.position.x < 20)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }
        if (time <= fogEnd)
        {
            FogRender.enabled = true;
        }
        else
        {
            FogRender.enabled = false;
        }
        if (time <= acidEnd)
        {
            damageMod = 3;
        }
        else
        {
            damageMod = 1;
        }

        //Why you no? Shit stopped working
        if ((TNT > 0) && (Input.GetKey(KeyCode.X)))
        {
            if (direction == "Down")
            {
                Instantiate(explosion, new Vector3(Character.playerx, Character.playery - 3, 0), Quaternion.identity);
            }
            if (direction == "Left")
            {
                Instantiate(explosion, new Vector3(Character.playerx - 3, Character.playery, 0), Quaternion.identity);
            }
            if (direction == "Right")
            {
                Instantiate(explosion, new Vector3(Character.playerx + 3, Character.playery, 0), Quaternion.identity);
            }
            TNT--;
        }
    }

    void FixedUpdate()
    {

    }
}
