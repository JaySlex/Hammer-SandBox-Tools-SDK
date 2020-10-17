using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public float Up;
    public float GateSpeed;

    public bool Openning;

    private Vector3 openPos;
    private Vector3 closePos;

    public AudioClip openClip;
    public AudioClip closeClip;
}
