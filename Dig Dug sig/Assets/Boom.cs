using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour
{

    public GameObject Player;
    private Character Playertime;
    private float tntTime = 0;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playertime = Player.GetComponent<Character>();
        tntTime = (float)Character.time + 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Character.time >= tntTime)
        {
            gameObject.SetActive(false);
        }

    }
}
