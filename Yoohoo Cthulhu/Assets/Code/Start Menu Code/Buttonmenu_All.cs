using UnityEngine;
using System.Collections;

public class Buttonmenu_All : MonoBehaviour {
    public GameObject[] buttons = new GameObject[15];
    public StartController StartController_Manager;
	// Use this for initialization
	void Start () {
        StartController_Manager = gameObject.GetComponent<StartController>();
        for (int i = 0; i < 15; i++)
        {
            if (i == 0 || i==1 || i==2 || i==3 || i== 13)
            {
                buttons[i].SetActive(true);
            }
            else
            {
                buttons[i].SetActive(false);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnMouseDown()
    {
        //if (gameObject.name == "Buttonmenu_Back" || gameObject.name == "Buttonmenu_Apply")
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        if (i > 4 || i == 16)
        //        {
        //            buttons[i].SetActive(false);
        //        }
        //        else
        //        {
        //            buttons[i].SetActive(true);
        //        }
        //    }
        //    StartController_Manager.selection = 0;
        //}
        //else if (gameObject.name == "Buttonmenu_Help")
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        if ((i > 6 && i < 9) || (i > 3 && i < 6))
        //        {
        //            buttons[i].SetActive(true);
        //        }
        //        else
        //        {
        //            buttons[i].SetActive(false);
        //        }
        //    }
        //    StartController_Manager.selection = 1;
        //}
        //else if (gameObject.name == "Buttonmenu_Option")
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        if (i == 14 || i == 12 || i == 9 || i == 7 || i == 6)
        //        {
        //            buttons[i].SetActive(true);
        //        }
        //        else
        //        {
        //            buttons[i].SetActive(false);
        //        }
        //    }
        //    StartController_Manager.selection = 2;
        //}
        //else if (gameObject.name == "Buttonmenu_HighScore")
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        if (i == 7)
        //        {
        //            buttons[i].SetActive(true);
        //        }
        //        else
        //        {
        //            buttons[i].SetActive(false);
        //        }
        //    }
        //    StartController_Manager.selection = 3;
        //}
        //else if (gameObject.name == "Buttonmenu_Quit")
        //{
        //    for (int i = 0; i < 15; i++)
        //    {
        //        if (i == 10 || i == 11)
        //        {
        //            buttons[i].SetActive(true);
        //        }
        //        else
        //        {
        //            buttons[i].SetActive(false);
        //        }
        //    }
        //    StartController_Manager.selection = 4;
        //}
    }
}
