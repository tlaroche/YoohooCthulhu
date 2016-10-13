using UnityEngine;
using System.Collections;

public class Item_Use : MonoBehaviour {

    public GameObject Player;
    private Character PlayerItem;

    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerItem = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey("1"))
        {
            PlayerItem.TNT--;
            Tnt();
        }
        else if(Input.GetKey("2"))
        {
            PlayerItem.Dash--;

        }
        else if(Input.GetKey("3"))
        {
            PlayerItem.Biomatter--;
        }
	}

    void Tnt()
    {
        
    }

    void Dash()
    {
        PlayerItem.Dash--;
        PlayerItem.speed = 50.5f;
        StartCoroutine(Wait());

    }

    void Biomatter()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.25f);
        PlayerItem.speed = 5.5f;
    }
}
