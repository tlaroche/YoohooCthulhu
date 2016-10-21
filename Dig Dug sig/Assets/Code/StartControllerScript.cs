using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartControllerScript : MonoBehaviour {
    public Texture2D Startmenu;
    public Texture2D OptionMenu;
    public Texture2D QuitMenu;
    public Texture2D HelpMenu;
    public Texture2D HighScoreScreen;

    public int Selection=0;

	// Use this for initialization
	void Start () {
        
    }

    void OnGUI()
    {
        if (Camera.current.name == "Main Camera")
        {
            if (Selection == 0)
            {
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Startmenu, ScaleMode.ScaleToFit);
            }
            else if (Selection == 1)
            {
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), OptionMenu, ScaleMode.ScaleToFit);
            }
            else if (Selection == 2)
            {
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), QuitMenu, ScaleMode.ScaleToFit);
            }
            else if (Selection == 3)
            {
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), HelpMenu, ScaleMode.ScaleToFit);
            }
            else if (Selection == 4)
            {
                GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), HighScoreScreen, ScaleMode.ScaleToFit);
            }
        }
    }

    // Update is called once per frame
    void Update () {
	    //if(Input.GetKeyDown(KeyCode.Alpha1))
     //   {
     //       SceneManager.LoadScene(1);
     //   }
     //   else if(Input.GetKeyDown(KeyCode.Alpha2))
     //   {

     //   }
     //   else if(Input.GetKeyDown(KeyCode.Alpha3))
     //   {
            
     //   }
     //   else if(Input.GetKeyDown(KeyCode.Alpha4))
     //   {
     //       Application.Quit();
     //   }
	}
}
