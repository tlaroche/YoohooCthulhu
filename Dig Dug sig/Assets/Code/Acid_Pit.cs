using UnityEngine;
using System.Collections;

public class Acid_Pit : MonoBehaviour {
    public GameObject Player;
    private Character Playerhealth;
    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Playerhealth = Player.GetComponent<Character>();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D hit)
    {
        Playerhealth.damageMod = 3;
        StartCoroutine(Wait());
        gameObject.SetActive(false);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(7f);
        Playerhealth.damageMod = 1;
    }
}
