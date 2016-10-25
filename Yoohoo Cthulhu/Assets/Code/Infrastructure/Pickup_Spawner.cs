using UnityEngine;
using System.Collections;

public class Pickup_Spawner : MonoBehaviour {
    public GameObject[] Items = new GameObject[50];
    Vector3 pos;
    int randomValue;

    // Use this for initialization
    void Start () {
        Instantiate(Items[0], new Vector3(0, -100, 0), Quaternion.identity);
        for (int y = 0; y < 1500; y += 10)
        {
            for (int x = -15; x < 15; x += 3)
            {
                randomValue = Random.Range(0, 50);
                if (Items[randomValue] != null)
                {
                    pos = new Vector3(x, -y, 0);
                    Instantiate(Items[randomValue], pos, Quaternion.identity);
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
