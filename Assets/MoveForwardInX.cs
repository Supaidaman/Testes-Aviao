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
        transform.position -= transform.up * Time.deltaTime * 20f;
    }
}
