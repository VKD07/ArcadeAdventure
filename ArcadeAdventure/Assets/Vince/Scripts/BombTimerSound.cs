using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BombTimerSound : MonoBehaviour
{
    [SerializeField] AudioClip timerSound;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayTimerSound()
    {
        audioSource.PlayOneShot(timerSound);
    }
}
