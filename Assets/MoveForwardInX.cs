using UnityEngine;
using System.Collections;

public class MoveForwardInX : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //????
        transform.position -= new Vector3(0,0,1) * Time.deltaTime * 20f;
    }
}
