using UnityEngine;
using System.Collections;
using System.Diagnostics;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public Stopwatch TimeCounter;
    public double time = 0;
    public Text Display;

    // Use this for initialization
    void Start () {
        TimeCounter = new Stopwatch();
        TimeCounter.Start();
        Display = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        time = TimeCounter.Elapsed.TotalSeconds;
        Display.text = "Time: "+ ((int)time).ToString();
    }
}
