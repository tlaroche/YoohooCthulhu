using UnityEngine;
using System.Collections;

public class Background1Script : MonoBehaviour
{
    public bool visible = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //Not on Camera
    void OnBecameInvisible()
    {
        visible = false;
    }
}