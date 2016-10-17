using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartControllerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(1);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            Application.Quit();
        }
	}
}
