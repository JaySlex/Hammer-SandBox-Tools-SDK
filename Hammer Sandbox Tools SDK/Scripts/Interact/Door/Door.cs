using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Interact/Door/Door")]
public class Door : MonoBehaviour
{
    private bool canOpen;

    public bool Open;

    [Header("Door Pos")]

    public Transform openRot;
    public Transform closeRot;
}
