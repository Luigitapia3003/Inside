using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject player = other.gameObject;
            player.SetActive(false);
            player.transform.position = respawnPoint.transform.position;
            player.SetActive(true);
        }
           
            
        
    }
}
