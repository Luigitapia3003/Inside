using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithThePlatform : MonoBehaviour
{
    CharacterController FPSController;

    Vector3 GroundPosition;
    Vector3 LastGroundPosition;
    string GroundName;
    string LastGroundName;

    private void Start()
    {
        FPSController = this.GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (FPSController.isGrounded)
        {
            RaycastHit hit;

            if (Physics.SphereCast(transform.position, FPSController.height / 4.2f, -transform.up, out hit))
            {
                GameObject groundedIn = hit.collider.gameObject;
                GroundName = groundedIn.name;
                GroundPosition = groundedIn.transform.position;

                if (GroundPosition != LastGroundPosition && GroundName == LastGroundName)
                {
                    this.transform.position += GroundPosition - LastGroundPosition;
                }

                LastGroundName = GroundName;
                LastGroundPosition = GroundPosition;
            }
        }

        else if (!FPSController.isGrounded)
        {
            LastGroundName = null;
            LastGroundPosition = Vector3.zero;
        }
    }


    private void OnDrawGizmos()
    {
        FPSController = this.GetComponent<CharacterController>();
        Gizmos.DrawWireSphere(transform.position, FPSController.height / 4.2f);
    }
}
