using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{

    [Header("CustomWeapon")]
    public string throwerName;
    public Sprite thrower_img;

    public int effectID;
    public Transform eject;
    [Header("Model")]
    public GameObject Equiped;
    public GameObject UnEquiped;
    public Animation anim;
    public string reloadAnimName = "reload";

    [Header("Ammo")]
    public float ammo;
    public float maxAmmo;
    public float reloadTime;

    public bool active;
    public bool isReloading;
}
