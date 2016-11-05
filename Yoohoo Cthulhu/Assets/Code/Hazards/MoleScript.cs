using UnityEngine;
using System.Collections;

public class MoleScript : MonoBehaviour {
    public GameObject[] tunnels = new GameObject[6];
    public float previousEulerZ = 0;
    float distanceToTravel;
    float distanceTravelled = 0;
    bool active = false;
    public Vector3 Pos;
    int incrementsCrossed = 0;
    float incrementValue = 2.56F;

	// Use this for initialization
	void Start () {
        distanceToTravel = Random.Range(8, 12);
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 4) * 90);
        previousEulerZ = transform.rotation.eulerAngles.z;
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

                previousEulerZ = transform.rotation.eulerAngles.z;
                transform.Rotate(0, 0, (Random.Range(1, 4) * 90));

                if(transform.rotation.eulerAngles.z == 270)
                {
                    transform.Rotate(0, 0, (Random.Range(1, 4) * 90));
                    Debug.Log(transform.rotation.eulerAngles);
                }
                if (transform.rotation.eulerAngles.z == (temp.eulerAngles.z + 180) % 360)
                {
                    transform.rotation = temp;
                }

                Pos = new Vector3(transform.position.x, transform.position.y, 0);

                if ((previousEulerZ == 90 && transform.rotation.eulerAngles.z == 0)) // Right then down
                {
                    Debug.Log("Right then Down");
                    Instantiate(tunnels[3],Pos,Quaternion.identity);
                }
                else if ((previousEulerZ == 270 && transform.rotation.eulerAngles.z == 0)) // Left then down
                {
                    Debug.Log("Left then Down");
                    Instantiate(tunnels[2], Pos, Quaternion.identity);
                }
                else if ((previousEulerZ == 0 && transform.rotation.eulerAngles.z == 270)) // Down then left
                {
                    Debug.Log("Down then Left");
                    Instantiate(tunnels[5], Pos, Quaternion.identity);
                }
                else if ((previousEulerZ == 0 && transform.rotation.eulerAngles.z == 90)) //Down then right
                {
                    Debug.Log("Down then Right");
                    Instantiate(tunnels[4], Pos, Quaternion.identity);
                }
                else if (transform.rotation.eulerAngles.z == 90 || transform.rotation.eulerAngles.z == 270) //Left or right
                {
                    Debug.Log("Right or Left");
                    Instantiate(tunnels[1], Pos, Quaternion.identity);
                }
                else if (transform.rotation.eulerAngles.z == 0 || transform.rotation.eulerAngles.z == 180) // Down
                {
                    Debug.Log("Down");
                    Instantiate(tunnels[0], Pos, Quaternion.identity);
                }
            }
        }
	}
    void OnBecameVisible()
    {
        active = true;
    }
}
