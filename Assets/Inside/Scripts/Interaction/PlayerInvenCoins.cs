using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInvenCoins : MonoBehaviour
{
    public int NumberOfCoins { get; private set; }

    public UnityEvent<PlayerInvenCoins> OnCoinsCollected;
    public void CoinsCollected()
    {
        NumberOfCoins++;
        OnCoinsCollected.Invoke(this);
    }
}
