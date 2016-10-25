using UnityEngine;
using System.Collections;

public class Buttongame_TNT : MonoBehaviour {

    // Use this for initialization
    public GameObject Player;
    private Character Inv;
    public GameObject TNTexplosion;

    void Start () {
        Player = GameObject.Find("Character");
        Inv = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (Inv.TNT > 0)
        {
            if (Player.transform.rotation == Quaternion.Euler(0, 0, 0))
            {
                Instantiate(TNTexplosion, new Vector3(Player.transform.position.x, Player.transform.position.y -6, 0), Quaternion.identity);
            }
            if (Player.transform.rotation == Quaternion.Euler(0, 0, -90))
            {
                Instantiate(TNTexplosion, new Vector3(Player.transform.position.x - 6, Player.transform.position.y, 0), Quaternion.identity);
            }
            if (Player.transform.rotation == Quaternion.Euler(0, 0, 90))
            {
                Instantiate(TNTexplosion, new Vector3(Player.transform.position.x + 6, Player.transform.position.y, 0), Quaternion.identity);
            }
            Inv.TNT--;
        }
    }
}
