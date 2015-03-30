using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

    public Camera outsideCamera;
    public Camera sitDownCamera;
	// Use this for initialization
	void Start () {
        outsideCamera.enabled = true;
        sitDownCamera.enabled = false; 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            outsideCamera.enabled = !outsideCamera.enabled;
            sitDownCamera.enabled = !sitDownCamera.enabled;
        }
	}
}
