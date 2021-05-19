using UnityEngine;
[AddComponentMenu("Hammer SandBox Tools SDK/Props/Grabs")]
public class Grabs : MonoBehaviour
{
    public float throwForce = 600;
    public float distanceToTake = 3;
    Vector3 objectPos;
    float distance;

   
    public bool canHold = true;
    public bool isHolding = false;



}
