using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSound : MonoBehaviour
{
    public AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
        source.PlayOneShot(sound);
    }
}
