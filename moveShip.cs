using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour
{


    private float moveSpeed = 10f;

    private float speed = -0;

    private float turnSpeed = 50f;




    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        move();

    }





    public void accelerer(float plus)
    {
        speed = speed + plus;

    }

    void move()
    {

        if (Input.GetKey(KeyCode.X) && speed < moveSpeed)
            accelerer(0.1f);

        if (Input.GetKey(KeyCode.W) && speed > 1f)
            accelerer(-0.1f);



        if (Input.GetKey(KeyCode.UpArrow))
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);

        transform.Translate(Vector3.up * speed * Time.deltaTime);

    }


}
