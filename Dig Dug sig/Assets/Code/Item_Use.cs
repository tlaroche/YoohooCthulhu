using UnityEngine;
using System.Collections;

public class Item_Use : MonoBehaviour {

    public GameObject Player;
    public GameObject[] Items = new GameObject[2];
    private Character PlayerItem;

    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerItem = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            PlayerItem.TNT--;
            Tnt();
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            PlayerItem.Dash--;
            Dash();

        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            PlayerItem.Biomatter--;
            Biomatter();
        }
	}

    void Tnt()
    {
        Instantiate(Items[1], gameObject.transform.position, Quaternion.identity);
    }

    void Dash()
    {
        PlayerItem.Dash--;
        PlayerItem.speed = 50.5f;
        StartCoroutine(Wait());

    }

    void Biomatter()
    {
        Instantiate(Items[0], gameObject.transform.position, Quaternion.identity);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.25f);
        PlayerItem.speed = 5.5f;
    }
}
