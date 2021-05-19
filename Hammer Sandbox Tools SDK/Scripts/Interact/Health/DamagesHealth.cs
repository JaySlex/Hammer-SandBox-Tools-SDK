using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Interact/Health/DamagesHealth")]
public class DamagesHealth : MonoBehaviour
{
    public int Damages;
    public bool DamageOneTime;
    public float DamagesRate;
    private float nextDamage;

    public bool Collision;
    public bool Trigger;

    private bool DamagesDone;


}
