using UnityEngine;
using System.Collections;

public class Yes_Quit : MonoBehaviour {

    public GameObject startController;
    public StartControllerScript SCS;

    // Use this for initialization
    void Start()
    {
        startController = GameObject.Find("StartController");
        SCS = startController.GetComponent<StartControllerScript>();
    }

    // Update is called once per frame
    void Update () {
	    if(SCS.Selection!=2)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
	}

    void OnMouseDown()
    {
        Application.Quit();
    }
}
