using UnityEngine;
using System.Collections;

public class Hazard_All : MonoBehaviour {

    public GameObject exploding;
    public Character Character_Management;
    //public Animator Hazard_GasPocketAnimator;
    //public AnimationClip Hazard_GasPocketAnimationClip;

    // Use this for initialization
    void Start () {
        Character_Management = GameObject.Find("Character").GetComponent<Character>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.name == "Character")
        {
            if (gameObject.tag == "AcidPit")
            {
                Character_Management.damageMod = 3;
                StartCoroutine(Waiting());
                gameObject.SetActive(false);
            }
            else if (gameObject.tag == "GasPocket")
            {
                Instantiate(exploding, transform.position, transform.rotation);
                Character_Management.DealDamage();
                gameObject.SetActive(false);
            }
            else if (gameObject.tag == "Rock")
            {
                if (Character_Management.transform.rotation.eulerAngles.z == 270)
                {
                    Character_Management.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else if (Character_Management.transform.rotation.eulerAngles.z == 90)
                {
                    Character_Management.transform.rotation = Quaternion.Euler(0, 0, 0);
                }
                else if (Character_Management.transform.rotation.eulerAngles.z == 0)
                {
                    Character_Management.transform.rotation = Quaternion.Euler(0, 0, 90);
                }
                Character_Management.controllable = false;
            }
        }
        else if (hit.tag == "TNTBoom")
        {
            gameObject.SetActive(false);
        }
    }
    void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.name == "Character")
        {
            Character_Management.controllable = true;
        }
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(10f);
        Character_Management.damageMod = 1;
    }
}
