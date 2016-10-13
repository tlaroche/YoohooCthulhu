using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    GameObject player;
    private Character Playerhealth;
    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
        Playerhealth = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(player.transform.position.x > -15 && player.transform.position.x < 15)
        {
            if(Character.direction == "Left")
            {
                transform.Translate(Vector3.left * Time.deltaTime * Playerhealth.speed);
            }
            if(Character.direction == "Right")
            {
                transform.Translate(Vector3.right * Time.deltaTime * Playerhealth.speed);
            }
        }
        if(Character.direction == "Down")
        {
            transform.Translate(Vector3.down * Time.deltaTime * Playerhealth.speed);
        }
	}
}
