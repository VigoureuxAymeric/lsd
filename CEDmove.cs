using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CEDmove : MonoBehaviour {
    //CED : CINGLES EXPLOSIFS DANGEREUX

    private Transform target;
    private Vector3 direction;
    private float turnspeed = 2f;

    private float speed = 13;

    void Start()
    {
        target = GameObject.Find("target").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("test");
        if (collision != null)
        {
            Destroy(this.gameObject,0.1f);
        }
    }

    void Update()
    {
        direction = target.position - this.transform.position;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * turnspeed);

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
