using UnityEngine;
using System.Collections;

public class Monster_All : MonoBehaviour {
    public GameObject Player;
    public Character Player_Manager;
    float pulseX, pulseY;
    // Use this for initialization
    void Start () {
        Player = GameObject.Find("Character");
        Player_Manager = Player.GetComponent<Character>();
        pulseX = 0;
        pulseY = 0;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.name == "Character")
        {
            if (gameObject.tag == "Tentacle")
            {
                Player_Manager.DealDamage();
            }
            if (gameObject.tag == "Mole")
            {
                Destroy(gameObject);
            }
            if (gameObject.tag == "Maw")
            {
                Player_Manager.DealDamage();
                Player_Manager.DealDamage();
                Player_Manager.DealDamage();
            }
            if (gameObject.tag == "Pulse")
            {
                pulseX = hit.gameObject.transform.position.x - transform.position.x;
                pulseY = hit.gameObject.transform.position.y - transform.position.y;
                if (pulseY > 0 && Mathf.Abs(pulseY) > Mathf.Abs(pulseX))
                {
                    if(hit.gameObject.transform.rotation.eulerAngles.z == 0)
                    {

                    }
                    else if (hit.gameObject.transform.rotation.eulerAngles.z == 90)
                    {
                        hit.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                    else if (hit.gameObject.transform.rotation.eulerAngles.z == 270)
                    {
                        hit.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                }
                else if (pulseX > 0)
                {
                    if (hit.gameObject.transform.rotation.eulerAngles.z == 0)
                    {
                        hit.gameObject.transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    if (hit.gameObject.transform.rotation.eulerAngles.z == 90)
                    {
                        hit.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                    if (hit.gameObject.transform.rotation.eulerAngles.z == 270)
                    {

                    }
                }
                else if (pulseX < 0)
                {
                    if (hit.gameObject.transform.rotation.eulerAngles.z == 0)
                    {
                        hit.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                    if (hit.gameObject.transform.rotation.eulerAngles.z == 90)
                    {

                    }
                    if (hit.gameObject.transform.rotation.eulerAngles.z == 270)
                    {
                        hit.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                }
            }
        }
    }
}
