using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGate : MonoBehaviour
{
    public float Down;
    public Gate gate;
    public float Timer;
    public float MassRequire;
    public bool PressurePad;
    public bool Button;
    private Vector3 Pressed;
    private Vector3 normal;
    public float ButtonSpeed;
    public bool Pressing;
    public float totalmass = 0;
}
