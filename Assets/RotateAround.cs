using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {
	

	public GameObject point;
	void Update ()
	{
		if (Input.GetMouseButton (1)) {
					
								transform.RotateAround (point.transform.position,new Vector3(0.0f,1.0f,0.0f),20 * Time.deltaTime * 2);
								
						
				}
		if (Input.GetMouseButton (0)) {
			
			transform.RotateAround (point.transform.position,new Vector3(0.0f,-1.0f,0.0f),20 * Time.deltaTime * 2);
		
			
		}

	}
	
	void Start ()
	{
		// Make the rigid body not change rotation
		//if (GetComponent<Rigidbody>())
			//GetComponent<Rigidbody>().freezeRotation = true;
	}
}