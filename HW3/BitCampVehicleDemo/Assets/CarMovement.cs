using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float velocity = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Alt method
        Vector3 myDirectionVector = new Vector3(0, 0, velocity * Time.deltaTime);
        transform.Translate(myDirectionVector);

    }

    void FixedUpdate()
    {
        
       // Vector3 myDirectionVector = new Vector3(0, 0, speed * Time.deltaTime);
       // transform.Translate(myDirectionVector);
        

    }
}
