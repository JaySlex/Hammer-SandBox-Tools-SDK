using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityBoost : MonoBehaviour
{
    public float speed;
    public ForceMode forceMode;
    public ForceDirection forceDirection;
    public Transform Custom;

    public void Boost(Rigidbody rb)
    {
        
    }


    public enum ForceDirection
    {
        PlayerVelocity,
        Up,
        Down,
        custom
    }
}
