using UnityEngine;
using System.Collections;

public class Acid_Pit : MonoBehaviour {
    private Character PlayerCharacter;
    // Use this for initialization
    void Start () {
        PlayerCharacter = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D hit)
    {
        //Seven Seconds of 3x damage
        Character.acidEnd = (int)Character.time + 7;
        gameObject.SetActive(false);
    }
}
