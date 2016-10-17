using UnityEngine;
using System.Collections;

public class Dirt_Pocket : MonoBehaviour
{
    private Character PlayerCharacter;

    // Use this for initialization
    void Start()
    {
        PlayerCharacter = GameObject.FindGameObjectWithTag("Player").GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        //That 10 seconds of dirt is really long
        Character.fogEnd = (int)Character.time + 10;
        gameObject.SetActive(false);
    }
}
