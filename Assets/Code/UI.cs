using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Diagnostics;

public class UI : MonoBehaviour {
    public Text Display;
    public Stopwatch Timer;
    public static double time;
	// Use this for initialization
	void Start () {
        Display = GetComponent<Text>();
        Timer = new Stopwatch();
        Timer.Start();
        time = 0;
       
	}
	
	// Update is called once per frame
	void Update () {
        time = (int)Timer.Elapsed.TotalSeconds;
        Display.text = "Timer: " + time + "\tHealth: ";
	}
}
