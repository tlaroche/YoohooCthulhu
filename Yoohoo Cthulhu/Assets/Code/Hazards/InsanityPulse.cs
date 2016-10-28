using UnityEngine;
using System.Collections;

public class InsanityPulse : MonoBehaviour {

    private float rate = 1.5F;
	// Use this for initialization
	void Start () {
        transform.localScale.Set(1, 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
	    if(transform.localScale.x > 100)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x + rate, transform.localScale.y + rate, transform.localScale.z);
        }
	}
}
