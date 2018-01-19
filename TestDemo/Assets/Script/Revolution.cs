using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour {
    public float revolutionSpeed = 0;
    GameObject sun;
    Vector3 axis,startPosition;
    // Use this for initialization
    void Start () {
        sun = GameObject.Find("Sun");
        axis = Vector3.Cross((transform.position-sun.transform.position), sun.transform.forward);
        //Debug.DrawLine(transform.position, transform.position, Color.red);
    }
	
	// Update is called once per frame
	void Update () {
        startPosition = transform.position;
        transform.RotateAround(sun.transform.position, axis, Time.deltaTime * revolutionSpeed);
        Debug.DrawLine(startPosition, transform.position, Color.red, 8);
    }

    //private void LateUpdate()
    //{
    //    Debug.DrawLine(startPosition, transform.position, Color.red);
    //}
}
