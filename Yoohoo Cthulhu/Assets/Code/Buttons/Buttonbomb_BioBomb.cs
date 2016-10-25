using UnityEngine;
using System.Collections;

public class Buttonbomb_BioBomb : MonoBehaviour {

    public GameObject Player;
    private Character Inv;
    public GameObject biobomb;

    void Start()
    {
        Player = GameObject.Find("Character");
        Inv = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (gameObject.name == "Biomatter Button")
        {
            if (Inv.BioBomb > 0)
            {
                Instantiate(biobomb, new Vector3(Player.transform.position.x, Player.transform.position.y, 0), Quaternion.identity);
                Inv.BioBomb--;
            }
        }
    }
}
