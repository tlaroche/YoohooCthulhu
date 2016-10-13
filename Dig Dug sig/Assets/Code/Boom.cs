using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.localScale+= new Vector3(100, 100, 0);
        Destroy(gameObject, .5f);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

}
