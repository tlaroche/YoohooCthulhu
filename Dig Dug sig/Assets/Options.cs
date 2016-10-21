using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour {

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
        if (SCS.Selection != 0)
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
        SCS.Selection = 1;
    }
}
