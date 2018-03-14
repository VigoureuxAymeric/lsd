using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpewpilote : MonoBehaviour
{

    public Rigidbody projectile;
    public Transform origine;
    public int force = 999999999;
    private float cooldown = 0.5f;
    private float time;

    private void Start()
    {
        time = cooldown;
    }
    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (time<=0)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Rigidbody instance;
                instance = Instantiate(projectile, origine.position, origine.rotation) as Rigidbody;
                instance.AddForce(origine.up * force);
               time=cooldown;
            }
        }
    }
}
