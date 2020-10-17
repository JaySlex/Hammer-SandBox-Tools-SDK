using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Door : MonoBehaviour
{
    private bool canOpen;

    public bool Open;

    [Header("Door Pos")]

    public Transform openRot;
    public Transform closeRot;
}
