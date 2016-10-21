using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

    public GameObject startController;
    public StartControllerScript SCS;

	// Use this for initialization
	void Start () {
        startController = GameObject.Find("StartController");
        SCS = startController.GetComponent<StartControllerScript>();
	}
	
	// Update is called once per frame
	void Update () {
	   
	}

    void OnMouseDown()
    {
        startController.GetComponent<StartControllerScript>().Selection = 0;
    }
}
