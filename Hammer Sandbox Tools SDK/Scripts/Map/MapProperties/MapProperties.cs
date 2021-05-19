using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Map/MapProperties")]
public class MapProperties : MonoBehaviour
{

    [Header("Properties")]
    [Tooltip("Activate or disable wallrunning")]
    public bool ActiveWallRun;
    [Tooltip("Activate or disable Global Damages")]
    public bool ActiveDamage;
    [Tooltip("Activate or disable Damages relative to velocity, like fall damages")]
    public bool ActiveVelDamages;
    [Tooltip("Activate or disable Damages relative to explosion")]
    public bool ActiveExplosiveDamages;
    [Tooltip("Activate or disable timer")]
    public bool ActiveTimer;
    [Tooltip("Set the max velocity before dying, set to 0 for disable")]
    public float MaxVel;
    [Tooltip("Set the gravity for any physics object")]
    public Vector3 gravity = new Vector3(0,-35,0);

    [Header("Player Properties")]
    public bool allowThirdPerson = true;
    public int StartHealth = 100;
    public float runSpeed = 10;
    public float walkSpeed = 7.5f;
    public float crouchSpeed = 5;
    public float MaxWallRunSpeed = 50;
    public float jumpForce = 400;
    public float AirSpeed = 50;
    public float MaxAirSpeed = 1;

    [Header("User")]
    [Tooltip("The thumbnail of the map")]
    public Sprite thumbnail;
    [Tooltip("The type of map")]
    public string MapType;
    [Tooltip("The game version of the map.")]
    public string MapVersion = "0.0.7";

    public void StartTimer()
    {
        
    }
    public void StopTimer()
    {
       
    }
    public void ResetTimer()
    {
        
    }
    public void SetTimer(float time)
    {
       
    }
    public void GoalReach()
    {

    }

    public void ShowTimer(bool value)
    {
        
    }
}
