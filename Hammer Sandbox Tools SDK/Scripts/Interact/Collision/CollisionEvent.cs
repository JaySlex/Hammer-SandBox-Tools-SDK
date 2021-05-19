using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class ColEvent : UnityEvent<Rigidbody>
{
}
[AddComponentMenu("Hammer SandBox Tools SDK/Interact/Collision/CollisionEvent")]
public class CollisionEvent : MonoBehaviour
{
    public ColEvent _OnCollisionEnter;
    public ColEvent _OnCollisionExit;
    public ColEvent _OnTriggerEnter;
    public ColEvent _OnTriggerExit;

    public bool detectOnlyPlayer;
}
