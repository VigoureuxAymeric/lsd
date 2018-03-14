using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpew : MonoBehaviour
{

    public Rigidbody projectile;
    public Transform origine;
    public int force = 999999999;
    private float time;
    private float cooldown = 0.25f;
    private float endcooldown;

    private void Start()
    {
        time = cooldown; 

    }
    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
      
        if (time <= 0) { 
            if (Input.GetKey(KeyCode.Space)) {
                Rigidbody instance;
                instance = Instantiate(projectile, origine.position, origine.rotation) as Rigidbody;
                instance.AddForce(origine.up * force);
                time = cooldown;

                
               
            }
        }
    }
}
