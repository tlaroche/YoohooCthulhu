using UnityEngine;
using System.Collections;

public class InputDetection : MonoBehaviour {
    public Vector2 position = new Vector2();
    public GameObject Player;
    private Character Inv;
    public GameObject explosion;
    public GameObject biobomb;
    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Inv = Player.GetComponent<Character>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        if (gameObject.name == "TNT Button")
        {
            if ((Inv.TNT > 0))
            {
                if (Character.direction == "Down")
                {
                    Instantiate(explosion, new Vector3(Character.playerx, Character.playery - 3, 0), Quaternion.identity);
                }
                if (Character.direction == "Left")
                {
                    Instantiate(explosion, new Vector3(Character.playerx - 3, Character.playery, 0), Quaternion.identity);
                }
                if (Character.direction == "Right")
                {
                    Instantiate(explosion, new Vector3(Character.playerx + 3, Character.playery, 0), Quaternion.identity);
                }
                Inv.TNT--;
            }
        }
        if (gameObject.name == "Biomatter Button")
        {
            if (Inv.Biomatter > 0)
            {
                Instantiate(biobomb, new Vector3(Character.playerx, Character.playery, 0), Quaternion.identity);
                Inv.Biomatter--;
            }
        }
        if (gameObject.name == "Dash Button")
        {
            Inv.Dash--;
            Inv.speed = 50.5f;
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.25f);
        Inv.speed = 5.5f;
    }

}
