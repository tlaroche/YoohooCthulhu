using UnityEngine;
using System.Collections;

public class Pickup_Spawner : MonoBehaviour {
    public GameObject[] Items0 = new GameObject[100];
    public GameObject[] Items1 = new GameObject[100];
    public GameObject[] Items2 = new GameObject[100];
    public GameObject[] Items3 = new GameObject[100];
    public GameObject[] Items4 = new GameObject[100];
    Vector3 pos;
    int randomValue;

    // Use this for initialization
    void Start () {
      //  Instantiate(Items0[0], new Vector3(0, -100, 0), Quaternion.identity);
      //  Instantiate(Items1[0], new Vector3(0, -100, 0), Quaternion.identity);
      //  Instantiate(Items2[0], new Vector3(0, -100, 0), Quaternion.identity);
      //  Instantiate(Items3[0], new Vector3(0, -100, 0), Quaternion.identity);
      // Instantiate(Items4[0], new Vector3(0, -100, 0), Quaternion.identity);
        for (int y = 0; y < 1500; y += 10)
        {
            for (int x = -15; x < 15; x += 3)
            {
                randomValue = Random.Range(0, 100);
                if (y < 300)
                {
                    if (Items0[randomValue] != null)
                    {
                        pos = new Vector3(x, -y, 0);
                        Instantiate(Items0[randomValue], pos, Quaternion.identity);
                    }
                }
                else if(y > 300 && y < 600)
                {
                    if (Items1[randomValue] != null)
                    {
                        pos = new Vector3(x, -y, 0);
                        Instantiate(Items0[randomValue], pos, Quaternion.identity);
                    }
                }
                else if(y > 600 && y < 900)
                {
                    if (Items2[randomValue] != null)
                    {
                        pos = new Vector3(x, -y, 0);
                        Instantiate(Items0[randomValue], pos, Quaternion.identity);
                    }
                }
                else if(y > 900 && y < 1200)
                {
                    if (Items3[randomValue] != null)
                    {
                        pos = new Vector3(x, -y, 0);
                        Instantiate(Items0[randomValue], pos, Quaternion.identity);
                    }
                }
                else if(y > 1200 && y < 1500)
                {
                    if (Items4[randomValue] != null)
                    {
                        pos = new Vector3(x, -y, 0);
                        Instantiate(Items0[randomValue], pos, Quaternion.identity);
                    }
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
