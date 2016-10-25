using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class HealthIcons : MonoBehaviour {

    private Character Player_main;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    // Use this for initialization
    void Start () {
        Player_main = GameObject.Find("Character").GetComponent<Character>();
    }
	
	// Update is called once per frame
	void LateUpdate () {
	    if (Player_main.health == 3)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(true);
        }
        else if (Player_main.health == 2)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(true);
            Heart3.SetActive(false);
        }
        else if (Player_main.health == 1)
        {
            Heart1.SetActive(true);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
        }
        else if (Player_main.health == 0)
        {
            Heart1.SetActive(false);
            Heart2.SetActive(false);
            Heart3.SetActive(false);
            SceneManager.LoadScene(3);
        }
    }
}
