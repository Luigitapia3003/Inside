using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSShooter : MonoBehaviour
{

    public GameObject Projectile;
    public Transform SpawnPoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject instance = Instantiate(Projectile, SpawnPoint.position, Quaternion.identity);
            instance.transform.localEulerAngles = transform.eulerAngles;
        }


    }
}
