using UnityEngine;
using System.Collections;

public class CameraTrack : MonoBehaviour {
    public Transform cameraTrack;
    public static int yvalue;
    // Use this for initialization
    void Start()
    {
        cameraTrack = GameObject.Find("Camera Track").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = cameraTrack.position;
        pos.z = transform.position.z;
        transform.position = pos;
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15, 15), (transform.position.y), transform.position.z);
    }
}
