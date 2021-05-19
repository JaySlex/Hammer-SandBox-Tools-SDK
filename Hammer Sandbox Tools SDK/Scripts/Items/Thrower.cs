using UnityEngine;
[AddComponentMenu("Hammer SandBox Tools SDK/Items/Weapons/Thrower")]
public class Thrower : ItemP
{
    public int effectID;
    public Transform eject;
    public Animation anim;
    public string reloadAnimName = "reload";

    [Header("Ammo")]
    public float ammo;
    public float maxAmmo;
    public float reloadTime;
    public bool isReloading;
}
