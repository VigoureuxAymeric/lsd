using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMouseLook : MonoBehaviour {
    public float rotationX;
    public float rotationY;
    public float sensitivity = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("MouseX : " + Input.mousePosition.x);
        //Debug.Log("MouseY : " + Input.mousePosition.y);
        //Debug.Log("MouseZ : " + Input.mousePosition.z);
        rotationX += Input.GetAxis("Mouse X") * sensitivity;
        rotationY -= Input.GetAxis("Mouse Y") * sensitivity;
        transform.rotation = Quaternion.Euler(0,rotationX,rotationY);

    }
}
