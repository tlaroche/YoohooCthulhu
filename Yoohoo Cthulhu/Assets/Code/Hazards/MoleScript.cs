using UnityEngine;
using System.Collections;

public class MoleScript : MonoBehaviour {
    float distanceToTravel;
    float distanceTravelled = 0;
    bool active = false;
    int incrementsCrossed = 0;
    float incrementValue = 2.56F;

	// Use this for initialization
	void Start () {
        distanceToTravel = Random.Range(8, 12);
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 4) * 90);
    }
	
	// Update is called once per frame
	void Update () {
        if (active == true)
        {
            if (incrementsCrossed > distanceToTravel)
            {
                Destroy(gameObject);
            }
            if (distanceTravelled < incrementValue*(incrementsCrossed+1))
            {
                distanceTravelled += incrementValue * Time.deltaTime * 2;
                transform.Translate(incrementValue * Time.deltaTime * 2, 0, 0);
            }
            else
            {
                incrementsCrossed++;
                Quaternion temp = transform.rotation;
                transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 4) * 90);
                if (transform.rotation.eulerAngles.z == (temp.eulerAngles.z + 180) % 360)
                {
                    transform.rotation = temp;
                }
            }
        }
	}
    void OnBecameVisible()
    {
        active = true;
    }
}
