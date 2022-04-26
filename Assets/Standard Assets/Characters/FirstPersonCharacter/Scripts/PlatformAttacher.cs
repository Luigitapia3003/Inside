using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttacher : MonoBehaviour
{
    public bool onPlatform = false;
    public Rigidbody rb;
    public Rigidbody platformRigidBody;
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (onPlatform)
            rb.velocity += new Vector3(platformRigidBody.velocity.x, 0, platformRigidBody.velocity.z);
    }
}
