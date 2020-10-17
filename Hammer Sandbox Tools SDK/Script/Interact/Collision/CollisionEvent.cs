using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
    public UnityEvent _OnCollisionEnter;
    public UnityEvent _OnCollisionExit;
    public UnityEvent _OnTriggerEnter;
    public UnityEvent _OnTriggerExit;

    public bool detectOnlyPlayer;
}
