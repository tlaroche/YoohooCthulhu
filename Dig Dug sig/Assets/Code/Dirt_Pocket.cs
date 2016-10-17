using UnityEngine;
using System.Collections;

public class Dirt_Pocket : MonoBehaviour
{

    public GameObject Player;
    private Character Playerhealth;
    private int fogTime = 0;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerhealth = Player.GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        //When current time = fogEnd the fog disappears in Character.cs
        Character.fogEnd = (int)Character.time + 5;
        gameObject.SetActive(false);
    }
}
