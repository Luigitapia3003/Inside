using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulable : Interactable
{
    Rigidbody rb;

    private bool isGrabed = false;
    private void Start()
    {
        base.Start();
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E) && isGrabed)
            Release();
    }
    public override void OnGrab(Transform parent)
    {
        rb.useGravity = false;
        rb.isKinematic = true;
        transform.SetParent(parent);
        isGrabed = true;
    }

    private void Release()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
        transform.SetParent(null);
        isGrabed = false;
    }

    public bool IsGrabbed()
    {
        return isGrabed;
    }
}
