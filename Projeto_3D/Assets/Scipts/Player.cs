using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rig;
    public float velocity;
    private bool isGrounded;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
            transform.position += move * Time.deltaTime * velocity;

            if (Input.GetAxis("Horizontal") > 0f)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            if (Input.GetAxis("Horizontal") < 0f)
            {
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
    }
   
}
