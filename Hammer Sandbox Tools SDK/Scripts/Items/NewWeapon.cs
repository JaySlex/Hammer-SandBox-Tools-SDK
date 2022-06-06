using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Items/Weapons/NewWeapon")]
public class NewWeapon : ItemP
{
    [Header("Weapon Stats")]
    public int damage;
    public float fireRate, range, reloadTime, reloadNoCockTime, drawTime;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;
    int bulletsLeft, bulletsShot;
    public bool shutgunReload;
    public bool shooting, readyToShoot, reloading, aimming;
    public Camera fpsCam;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public float hitForce = 1500;

    [Header("Spread")]
    public float maxSpread = 0.1f;
    public float spread;
    public float spreadAddedByShot = 0.05f;
    public float regainSpreadPower = 0.5f;
    private float shootingSpread;
    private float movementSpread;

    [Header("Effect")]
    public int muzzleFlashEffectID = 29;
    public float muzzleDurationTime;
    public float bulletHoleDuration;

    [Header("Sway")]
    public float amount = 0.01f;
    public float maxAmount = 0.02f;
    public float smoothAmount = 6f;
    public float MoveAmount = 0.01f;
    public float MoveMaxAmount = 0.02f;
    public float MoveSmoothAmount = 6;
    private Vector3 currentPos;
    public bool SwayEnable;

    [Header("Aim")]
    public bool AimEnabled;
    [Range(0, 5)]
    public float aimMultiplier = 1;
    private Vector3 normalPos;
    public Vector3 aimPosition;

    [Header("Animation")]
    public Animation anim;
    public List<string> draw_anims;
    public List<string> fire_anims;
    public List<string> reload_anims;
    public List<string> reloadNoCock_anims;

    [Header("UI")]
    public bool ShutGunShow;
}
