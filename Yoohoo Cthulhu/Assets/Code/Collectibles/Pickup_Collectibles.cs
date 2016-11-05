using UnityEngine;
using System.Collections;

public class Pickup_Collectibles : MonoBehaviour {

    public Score Score_main;
    public GameObject[] Collectibles = new GameObject[3];
    
    // Use this for initialization
    void Start () {
        Score_main = GameObject.Find("Canvas").GetComponent<Score>();
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.name == "Character")
        {
            if (gameObject.tag == "Nougat")
            {
                Score.gameScore += 50;
            }
            else if (gameObject.tag == "Saphire")
            {
                Score.gameScore += 100;
            }
            else if (gameObject.tag == "Diamond")
            {
                Score.gameScore += 200;
            }
            gameObject.SetActive(false);
        }
        else if(hit.tag == "TransmutationEffect")
        {
            if (gameObject.tag == "Nougat")
            {
                Instantiate(Collectibles[1],transform.position,Quaternion.identity);
            }
            else if (gameObject.tag == "Saphire")
            {
                Instantiate(Collectibles[2], transform.position, Quaternion.identity);
            }
            else if (gameObject.tag == "Diamond")
            {
                Instantiate(Collectibles[2], transform.position, Quaternion.identity);
            }
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
