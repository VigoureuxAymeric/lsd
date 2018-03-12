using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    private Transform target;
    private Vector3 direction;
    private float turnspeed = 7f;

    private float speed = 10;

    void Start()
    {
        target = GameObject.Find("target").transform;
    }

    void Update()
    {
        direction = target.position - this.transform.position;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * turnspeed);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
