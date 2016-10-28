using UnityEngine;
using System.Collections;

public class Background2Script : MonoBehaviour {
    public bool visible = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //Not on Camera
    void OnBecameInvisible()
    {
        visible = false;
    }
}
