using UnityEngine;
using System.Collections;

public class Dash : MonoBehaviour {

    public GameObject Player;
    private Character PlayerInv;

    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerInv = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {

        PlayerInv.Dash++;
        gameObject.SetActive(false);
    }
}
