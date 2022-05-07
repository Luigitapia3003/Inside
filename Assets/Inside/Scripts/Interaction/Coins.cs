using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        PlayerInvenCoins playerInvenCoins = other.GetComponent<PlayerInvenCoins>();

        if (playerInvenCoins != null)
        {
            playerInvenCoins.CoinsCollected();
            gameObject.SetActive(false);
            
        }
    }
}
