using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarHandler : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    //Multipliers
    float accelerationMultiplier = 3.0f;
    float breaksMultiplier = 15.0f;
    float steeringMultiplier = 5.0f;

    //Input
    Vector2 input = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void FixedUpdate()
    {
        //Apply Acceleration
        if(input.y > 0)
            Accelerate();
        else
            rb.linearDamping = 0.2f;

        //Apply Breaks
        if (input.y < 0)
            Break();
        
        Steer();
    }

    void Accelerate()
    {
        rb.linearDamping = 0;

        rb.AddForce(rb.transform.forward * 10 * accelerationMultiplier * input.y);
    }

    void Break()
    {
        //Don't break unless we are going forward
        if (rb.linearVelocity.z <= 0)
            return;
        
        rb.AddForce(rb.transform.forward * breaksMultiplier * input.y);
    }

    void Steer()
    {
        if (Mathf.Abs(input.x) > 0)
        {
            rb.AddForce(rb.transform.right * steeringMultiplier * input.x);
        }
    }

    public void SetInput(Vector2 inputVector)
    {
        inputVector.Normalize();

        input = inputVector;
    }
}
