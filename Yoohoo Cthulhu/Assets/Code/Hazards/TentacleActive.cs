using UnityEngine;
using System.Collections;

public class TentacleActive : MonoBehaviour {
    // Use this for initialization
    void Start () {
        
	}
    void OnBecameVisible()
    {
        frame1();
    }

    // Update is called once per frame
    void Update () {
	
	}
    void frame1()
    {
        Invoke("frame2", .1f);
    }
    void frame2()
    {
        Invoke("frame3", .1f);
    }
    void frame3()
    {
        Invoke("frame4", .1f);
    }
    void frame4()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        Invoke("frame5", 1f);
    }
    void frame5()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        Invoke("frame6", .1f);
    }
    void frame6()
    {
        Invoke("frame1", .1f);
    }
}
