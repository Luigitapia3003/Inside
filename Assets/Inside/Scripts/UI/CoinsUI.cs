using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsUI : MonoBehaviour
{
    private TextMeshProUGUI coinText;
   
    void Start()
    {
        coinText = GetComponent<TextMeshProUGUI>();
    }

  
    public void UpdateCoinText(PlayerInvenCoins playerInvenCoins)
    {
        coinText.text = playerInvenCoins.NumberOfCoins.ToString();
    }
}
