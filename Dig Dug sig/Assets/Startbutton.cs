using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Startbutton : MonoBehaviour
{

    public GameObject startController;
    public StartControllerScript SCS;

    // Use this for initialization
    void Start()
    {
        startController = GameObject.Find("StartController");
        SCS = startController.GetComponent<StartControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SCS.Selection == 0)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}

