using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public float moonAutoSpeed = 0;
    public float moonRevolution = 0;
    GameObject earth;
    Vector3 axis;
    // Use this for initialization
    void Start()
    {
        earth = GameObject.Find("Earth");
        axis = Vector3.Cross((transform.position - earth.transform.position), earth.transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(earth.transform.position, axis, Time.deltaTime * moonRevolution);
        transform.Rotate(Vector3.up, Time.deltaTime * moonAutoSpeed);
    }
}
