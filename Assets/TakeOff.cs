using UnityEngine;
using System.Collections;

public class TakeOff : MonoBehaviour {
    private int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(changeHeight());
        
	
	}

    IEnumerator changeHeight()
    {
        // obviously,needs much more work than this.
        if (speed < 100)
        {
            transform.position += new Vector3(0, 1, 0);
            speed++;
            transform.Rotate(new Vector3(0,0,1), 0.5f);
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }
        yield return new WaitForSeconds(10);
    }
    }