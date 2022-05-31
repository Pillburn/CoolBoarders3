using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float torqAmt = 1.0f;
     public float speedAmt = 10f;
     public float boostAmt = 30f;
    Rigidbody2D rb2d;
    SurfaceEffector2D se2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        se2d = FindObjectOfType<SurfaceEffector2D>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerRotate();
        RespondToBoost();
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            goBoostSpeed();
            Invoke("returnBaseSpeed",1);

        }
    }

    void returnBaseSpeed()
    {
        se2d.speed = speedAmt;
    }

    void goBoostSpeed()
    {
        se2d.speed = boostAmt;
    }

    void PlayerRotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqAmt);


        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqAmt);

        }
    }
}
