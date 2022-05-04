using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Locked : Interactable
{
    public int ID;

    public int index;
    public override void OnInteraction()
    {
        Debug.Log("Trying to acess...");
        if (Inventory.HasKey(ID))
            OpenLock();
        else
            Debug.Log("Can't Open...");

    }


    void OpenLock()
    {
        Debug.Log("Open");
        GetComponent<Animator>().enabled = true;
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(index);
    } 
}
