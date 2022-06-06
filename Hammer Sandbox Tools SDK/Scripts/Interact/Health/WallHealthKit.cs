using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Interact/Health/WallHealthKit")]
public class WallHealthKit : MonoBehaviour
{
    public int HealthToAdd;
    public float HealthRate;
    private float nextHealth;
    public bool HealthOneTime;
    private bool HealthDone;
    public bool Collision;
    public bool Trigger;

    public void AddHealth()
    {

    }
}
