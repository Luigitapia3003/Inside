using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jaula : MonoBehaviour
{
    public int KeyCubesNecesarios;


  
    void Update()
    {
        if (Container.keyCubes == KeyCubesNecesarios)
        {
            gameObject.SetActive(false);
        }
    }
}
