using UnityEngine;
using System.Collections;

public class CameraScripts : MonoBehaviour {
    private Character Player_main;

	// Use this for initialization
	void Start () {
        Player_main = GameObject.Find("Character").GetComponent<Character>();
	}
	
	// Update is called once per frame
	void Update () {
        
        if ((Player_main.transform.position.x != gameObject.transform.position.x) && (Player_main.transform.position.x >= -10 && Player_main.transform.position.x <= 10))
        {
            transform.position = new Vector3(Player_main.transform.position.x , transform.position.y, transform.position.z);

        }
        else
        {
            if (Player_main.transform.rotation == Quaternion.Euler(0, 0, 270) && (Player_main.transform.position.x > -10) && (Player_main.transform.position.x < 10))
            {
                transform.Translate(Vector3.left * Time.deltaTime * Player_main.speed);
            }
            if (Player_main.transform.rotation == Quaternion.Euler(0, 0, 90) && (Player_main.transform.position.x < 10) && (Player_main.transform.position.x > -10))
            {
                transform.Translate(Vector3.right * Time.deltaTime * Player_main.speed);
            }
            if (Player_main.transform.rotation == Quaternion.Euler(0, 0, 0))
            {
                transform.Translate(Vector3.down * Time.deltaTime * Player_main.speed);
            }
        }
        
        //transform.position = new Vector3(Player_main.transform.position.x, Player_main.transform.position.y - 7, transform.position.z);
    }
}
