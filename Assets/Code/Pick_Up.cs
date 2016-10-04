using UnityEngine;
using System.Collections;

public class Pick_Up : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}


    void OnTriggerEnter2D(Collider2D hit)
    {
        
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
