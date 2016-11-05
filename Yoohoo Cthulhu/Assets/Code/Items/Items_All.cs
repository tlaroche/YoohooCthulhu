using UnityEngine;
using System.Collections;

public class Items_All : MonoBehaviour
{
    public Character Character_Management;
    // Use this for initialization
    void Start()
    {
        Character_Management = GameObject.Find("Character").GetComponent<Character>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.tag != "BioBomb")
        {
            if(gameObject.tag == "TNT")
            {
                Character_Management.TNT++;
            }
            else if(gameObject.tag == "BioBomb")
            {
                Character_Management.BioBomb++;
            }
            else if(gameObject.tag == "Dash")
            {
                Character_Management.Dash++;
            }
            else if(gameObject.tag == "PlotArmor")
            {
                Character_Management.damageMod = 0;
                StartCoroutine(Wait());
            }
            else if(gameObject.tag == "SloMo")
            {
                Time.timeScale = .5f;
                Invoke("TimeScale", 5f);
            }
            else if(gameObject.tag == "TransmutationField")
            {
                Character_Management.transmutationExpire = 10;
            }
            gameObject.SetActive(false);
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        Character_Management.damageMod = 1;
    }

    void TimeScale()
    {
        Time.timeScale = 1f;
    }
}
