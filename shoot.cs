using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    private bool active = true;
    private float cooldown = 2;
    private float shortcooldown = 0.35f;
    private float timer;
    private int shot = 0;


    void Update()
    {
        Shoot();
        cd();
    }


    void Shoot()
    {
        if (timer == 0)
        {
            Debug.Log("ça tire ?");
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            //  bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            active = true;
            shot++;
            if (shot == 3)
            {
                timer = cooldown;
                shot = 0;
            }
            else
            {
                timer = shortcooldown;
            }
        }
    }

    void cd()
    {
        if (active)
        {
            timer -= Time.deltaTime;    //Subtract the time since last frame from the timer.

            if (timer <= 0)
            {
                timer = 0;
                active = false;

            }
        }
            
                          

        
    }
}