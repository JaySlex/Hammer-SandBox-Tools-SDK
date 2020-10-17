using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    [Header("User")]
    [Tooltip("The thumbnail of the map")]
    public Sprite thumbnail;
    [Tooltip("The type of map")]
    public string MapType;




}
