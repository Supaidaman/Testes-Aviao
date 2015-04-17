using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

    public GameObject outsideCamera;
    public GameObject sitDownCamera;
    bool t = true;
    bool f = false;
	// Use this for initialization
	void Start () {
        outsideCamera.SetActive( true);
        sitDownCamera.SetActive(false); 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            outsideCamera.active = !outsideCamera.active;
            sitDownCamera.active = !sitDownCamera.active;
        }
	}
}
