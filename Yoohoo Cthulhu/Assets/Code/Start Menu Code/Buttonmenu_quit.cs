using UnityEngine;
using System.Collections;

public class Buttonmenu_quit : MonoBehaviour
{

    public Buttonmenu_All All_Manager;
    public StartController StartController_Manager;

    // Use this for initialization
    void Start()
    {
        All_Manager = GameObject.Find("Start_Controller").GetComponent<Buttonmenu_All>();
        StartController_Manager = GameObject.Find("Start_Controller").GetComponent<StartController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        Debug.Log("Input Received");
        if (gameObject.name == "Buttonmenu_Back" || gameObject.name == "Buttonmenu_Apply" || gameObject.name == "Buttonmenu_No")
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 0 || i==1 || i==2 || i==3 || i==13 )
                {
                    All_Manager.buttons[i].SetActive(true);
                }
                else
                {
                    All_Manager.buttons[i].SetActive(false);
                }
            }
            StartController_Manager.selection = 0;
        }
        else if (gameObject.name == "Buttonmenu_Help")
        {
            for (int i = 0; i < 15; i++)
            {
                if ((i > 6 && i < 9) || (i > 3 && i < 6))
                {
                    All_Manager.buttons[i].SetActive(true);
                }
                else
                {
                    All_Manager.buttons[i].SetActive(false);
                }
            }
            StartController_Manager.selection = 1;
        }
        else if (gameObject.name == "Buttonmenu_Option")
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 14 || i == 12 || i == 9 || i == 7 || i == 6)
                {
                    All_Manager.buttons[i].SetActive(true);
                }
                else
                {
                    All_Manager.buttons[i].SetActive(false);
                }
            }
            StartController_Manager.selection = 2;
        }
        else if (gameObject.name == "Buttonmenu_HighScore")
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 7)
                {
                    All_Manager.buttons[i].SetActive(true);
                }
                else
                {
                    All_Manager.buttons[i].SetActive(false);
                }
            }
            StartController_Manager.selection = 3;
        }
        else if (gameObject.name == "Buttonmenu_Quit")
        {
            for (int i = 0; i < 15; i++)
            {
                if (i == 10 || i == 11)
                {
                    All_Manager.buttons[i].SetActive(true);
                }
                else
                {
                    All_Manager.buttons[i].SetActive(false);
                }
            }
            StartController_Manager.selection = 4;
        }
    }
}
