using UnityEngine;
using System.Collections;

public class TNTBoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Wait());
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.2f);
        gameObject.SetActive(false);
    }
}
