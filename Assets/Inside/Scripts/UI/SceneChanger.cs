using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class SceneChanger : MonoBehaviour
    {
        public Animator FadeBox;
        public void GoToScene(int index)
        {
            FadeBox.SetInteger("State", 1);
            StartCoroutine(WaitForFade(index));
        }

        IEnumerator WaitForFade(int index)
        {

            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene(index);
        }

    public void ExitGame()
    {
        Application.Quit();
    }
    }

