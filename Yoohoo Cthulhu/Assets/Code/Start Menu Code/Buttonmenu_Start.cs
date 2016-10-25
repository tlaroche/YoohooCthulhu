using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Buttonmenu_Start : MonoBehaviour {

    public StartController StartController_Manager;

	// Use this for initialization
	void Start () {
        StartController_Manager = GameObject.Find("Start_Controller").GetComponent<StartController>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}
