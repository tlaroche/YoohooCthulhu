using UnityEngine;
using System.Collections;

public class Scroll_Background : MonoBehaviour {

    private Camera MainCamera;
    private GameObject Background1;
    private GameObject Background2;
    // Use this for initialization
    void Start () {
        MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        Background1 = GameObject.Find("BG1");
        Background2 = GameObject.Find("BG2");
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Hardcoded size of bg is 200? aligned bg1 and bg2 are 100 pixels away from each other - redraw if not visible
    }
}
