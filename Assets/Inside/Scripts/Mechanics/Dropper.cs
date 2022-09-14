using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    public GameObject[] droplist;

    public void Drop(Vector3 position)
    {
        int index = Random.Range(0, droplist.Length);

        GameObject drop = droplist[index];

        Instantiate(drop, position, Quaternion.identity);
    }

}
