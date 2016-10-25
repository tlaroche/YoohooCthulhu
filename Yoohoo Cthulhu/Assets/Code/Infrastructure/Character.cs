using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public float speed = 20f;
    public int health = 3;
    public bool controllable;

    public int damageMod = 1;
    public int dustExpire = 0;
    public int acidExpire = 0;
    public int dashExpire = 0;

    //Starting With Items for testing
    public int TNT = 3;
    public int Dash = 3;
    public int BioBomb = 3;
    public int PlotArmor = 3;
    public Vector2 swipe = new Vector2();

    public Timer Timer_main;

    // Use this for initialization
    void Start () {
        Timer_main = GameObject.Find("Canvas").GetComponent<Timer>();
        controllable = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.rotation.z != 270 && controllable == true)
        {
            if (transform.rotation.eulerAngles.z != 90)
                transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.rotation.z != 90 && controllable == true)
        {
            if (transform.rotation.eulerAngles.z != 270)
                transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.rotation.z != 0 && controllable == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.touchCount > 0)
        {
            swipe = Input.GetTouch(0).deltaPosition;
            if (Mathf.Abs(swipe.x) > Mathf.Abs(swipe.y) + 10)
            {
                if (swipe.x > 5 && controllable == true)
                {
                    if(transform.rotation.eulerAngles.z != 270)
                    transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                else if (swipe.x < -5 && controllable == true)
                {
                    if(transform.rotation.eulerAngles.z != 90)
                    transform.rotation = Quaternion.Euler(0, 0, 270);
                }
            }
            else if (Mathf.Abs(swipe.y) + 10 > Mathf.Abs(swipe.x))
            {
                if (swipe.y < -5 && controllable == true)
                {
                    transform.rotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }

        if (transform.position.x < -19)
        {
            transform.position = new Vector3(-19, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (transform.position.x > 19)
        {
            transform.position = new Vector3(19, transform.position.y, transform.position.z);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * speed);
        //Debug.Log(transform.position.x);

    }

    public void DealDamage()
    {
        health = health - damageMod;
    }
}
