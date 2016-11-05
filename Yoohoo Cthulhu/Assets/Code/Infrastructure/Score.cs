using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int gameScore = 0;
    public Text Display;
	// Use this for initialization
	void Start () {
        Display = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
        Display.text = "Score: " + gameScore.ToString();
	    
	}
}
