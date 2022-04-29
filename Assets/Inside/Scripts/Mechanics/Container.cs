using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    public static int keyCubes;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KeyCube")
            keyCubes++;
    }

}
