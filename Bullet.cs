using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    private float speed = 15f;

    // Use this for initialization
    void Start () {
		Destroy(this.gameObject, 3);


	}
  private void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            Destroy(this.gameObject, 0.1f);
        }
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
      
	}
}
