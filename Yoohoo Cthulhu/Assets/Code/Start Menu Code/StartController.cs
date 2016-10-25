using UnityEngine;
using System.Collections;

public class StartController : MonoBehaviour {

    public Sprite[] Menus = new Sprite[5];
   // public float width;
    GameObject Menu_Image;
    public int selection;
    // Use this for initialization
    void Start () {
        //width = Camera.main.orthographicSize * 2 * Screen.width / Screen.height;
        selection = 0;
        Menu_Image = GameObject.Find("Menu_Image");
        Menu_Image.transform.localScale = new Vector3(1,1,1);
	}
	
	// Update is called once per frame
	void Update () {

           Menu_Image.GetComponent<SpriteRenderer>().sprite = Menus[selection];
	}
}
