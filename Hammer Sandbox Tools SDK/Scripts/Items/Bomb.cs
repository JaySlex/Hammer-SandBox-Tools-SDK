using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : ItemP
{
    [Header("Time")]
    public float timer;
    public float timeBeforeExplosion;
    public bool Used;
    [Header("Audio")]
    public AudioClip bip;
    public AudioClip lastBip;
    private AudioSource source;

    private float nextbip = 0f;
}
