using UnityEngine;
using System.Collections;

public class Gas_Pocket : MonoBehaviour {

    // Use this for initialization
    public GameObject Player;
    private Character Playerhealth;
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerhealth = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D hit)
    {
        Playerhealth.health--;
        gameObject.SetActive(false);
    }
}
