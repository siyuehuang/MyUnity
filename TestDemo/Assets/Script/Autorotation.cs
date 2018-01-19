using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autorotation : MonoBehaviour
{
    public float autoRotationSpeed = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * autoRotationSpeed);
    }
}
