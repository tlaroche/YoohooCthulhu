using UnityEngine;
using System.Collections;

public class Buttongame_Dash : MonoBehaviour {

    private Character Player_main;
    // Use this for initialization
    void Start () {
        Player_main = GameObject.Find("Character").GetComponent<Character>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Player_main.speed = 50.5f;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.5f);
        Player_main.speed = 5.5f;
    }
}
