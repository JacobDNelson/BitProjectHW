using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarMovement : MonoBehaviour
{
    public float velocity = 120.0f;
    public float turnSpeed;
    private float horiz;
    private float forw;
    public float boost;

    // Rigidbody rb;



    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Alt method
        // Vector3 myDirectionVector = new Vector3(0, 0, speed * Time.deltaTime);

    }

    void FixedUpdate()
    {
        if (true)
        {
            boost = Input.GetAxis("Jump");
            horiz = Input.GetAxis("Horizontal");
            forw = Input.GetAxis("Vertical");

            Vector3 myDirectionVector = new Vector3(0, 0, velocity);
            //Causes issues when paired with RigidBody
            transform.Translate(myDirectionVector * (forw + 2 * boost));
            //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizInput);
            //rb.AddForce(myDirectionVector);


            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horiz);
        }

    }
}
