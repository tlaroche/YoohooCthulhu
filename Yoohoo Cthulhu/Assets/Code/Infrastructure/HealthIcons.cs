using UnityEngine;
using System.Collections;

public class HealthIcons : MonoBehaviour {

    private Character Player_main;
    // Use this for initialization
    void Start () {
        Player_main = GameObject.Find("Character").GetComponent<Character>();
    }
	
	// Update is called once per frame
	void LateUpdate () {
	    if (Player_main.health == 3)
        {
            GameObject.Find("Icon_Health1").SetActive(true);
            GameObject.Find("Icon_Health2").SetActive(true);
            GameObject.Find("Icon_Health3").SetActive(true);
        }
        else if (Player_main.health == 2)
        {
            GameObject.Find("Icon_Health1").SetActive(true);
            GameObject.Find("Icon_Health2").SetActive(true);
            GameObject.Find("Icon_Health3").SetActive(false);
        }
        else if (Player_main.health == 1)
        {
            GameObject.Find("Icon_Health1").SetActive(true);
            GameObject.Find("Icon_Health2").SetActive(false);
            GameObject.Find("Icon_Health3").SetActive(false);
        }
        else if (Player_main.health == 0)
        {
            GameObject.Find("Icon_Health1").SetActive(false);
            GameObject.Find("Icon_Health2").SetActive(false);
            GameObject.Find("Icon_Health3").SetActive(false);
        }
    }
}
