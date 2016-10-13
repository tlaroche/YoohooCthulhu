using UnityEngine;
using System.Collections;

public class Dirt_Pocket : MonoBehaviour {

    public GameObject PlayerFog;
    private Renderer FogRender;

    // Use this for initialization
    void Start () {
        PlayerFog = GameObject.FindGameObjectWithTag("DirtBaby");
        FogRender = PlayerFog.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D hit)
    {
        FogRender.enabled = true;
        StartCoroutine(Wait());
        gameObject.SetActive(false);
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10f);
        FogRender.enabled = false;
    }
}
