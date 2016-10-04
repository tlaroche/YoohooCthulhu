using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public static float speed = 5.5f;
    public CameraTrack follow;
    public static string direction = "";
    public static float playerx;
    public static float playery;
    public int distanceSpawn;
    public int health = 3;

    // Use this for initialization
    void Start ()
    {

        //rb = new Rigidbody2D();
        //pickup = GameObject.Find("Pick_Up");
       // level1Start = transform.position.y;
        //distanceSpawn = 0;
        //rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

	// Update is called once per frame
	void Update ()
    {
        playerx = transform.position.x;
        playery = transform.position.y;

        if (Input.GetKey(KeyCode.LeftArrow) && direction != "Right")
        {
            direction = "Left";
        }
        else if (Input.GetKey(KeyCode.RightArrow) && direction != "Left")
        {
            direction = "Right";
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction = "Down";
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
    }

    void FixedUpdate()
    {

    }
}
