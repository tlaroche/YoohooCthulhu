using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Diagnostics;

public class UI : MonoBehaviour {
    public Text Display;
    public Stopwatch Timer;
    public static double time;
    public GameObject Player;
    private Character Playerhealth;
    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerhealth = Player.GetComponent<Character>();
        Display = GetComponent<Text>();
        Timer = new Stopwatch();
        Timer.Start();
        time = 0;
       
	}
	
	// Update is called once per frame
	void Update () {
        time = (int)Timer.Elapsed.TotalSeconds;
        Display.text = "Timer: " + time + "\tHealth: "+Playerhealth.health + "\tTNT: "+Playerhealth.TNT + "\tDash: " + Playerhealth.Dash + "\tBiomatter: " + Playerhealth.Biomatter;
	}
}
