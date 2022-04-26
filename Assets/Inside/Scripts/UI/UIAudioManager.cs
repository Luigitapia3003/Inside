using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudioManager : MonoBehaviour
{
    public AudioClip[] sfxclips;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySFX(int index)
    {
        audioSource.clip = sfxclips[index];
        audioSource.Play();
    }
}
