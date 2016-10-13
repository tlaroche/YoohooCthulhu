using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {

    public GameObject Player;
    private Character Playerhealth;
    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerhealth = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (Character.direction == "Down")
        {
            Character.direction = "Right";
        }
        else if (Character.direction == "Left" || Character.direction == "Right")
        {
            Character.direction = "Down";
        }
    }
}
