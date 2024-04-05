using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCar : MonoBehaviour
{
    public float groundRaycastDistance = 1f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        // Cast a ray downward to detect the road mesh
        if (Physics.Raycast(transform.position, -transform.up, out hit, groundRaycastDistance))
        {
            // Check if the hit collider belongs to the road (based on collider type or mesh renderer)
            if (hit.collider.GetComponent<MeshRenderer>() != null)
            {
                // Calculate the force direction (opposite of road normal)
                Vector3 forceDirection = -hit.normal;

                // Apply the force to the car
                rb.AddForce(forceDirection * rb.mass * Physics.gravity.magnitude, ForceMode.Force);
            }
        }
    }
}


