using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Depth : MonoBehaviour {

    public Character CharacterScript_Manager;
    public Text CurrentDepth;
	// Use this for initialization
	void Start () {
        CharacterScript_Manager = GameObject.Find("Character").GetComponent<Character>();
        CurrentDepth = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        CurrentDepth.text = "Depth: " + ((int)Mathf.Abs(CharacterScript_Manager.transform.position.y)).ToString();
        if((int)Mathf.Abs(CharacterScript_Manager.transform.position.y) >= 900)
        {
            SceneManager.LoadScene(2);
        }
	}
}
