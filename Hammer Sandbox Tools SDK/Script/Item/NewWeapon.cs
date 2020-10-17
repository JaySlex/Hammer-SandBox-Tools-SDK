using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWeapon : MonoBehaviour
{
    [Header("CustomWeapon")]
    public string weaponName;
    public Sprite weapon_img;

    [Header("Weapon Stats")]
    public int damage;
    public float fireRate, range, reloadTime, timeBetweenShots, drawTime;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;
    int bulletsLeft, bulletsShot;
    public bool shutgunReload;
    public bool shooting, readyToShoot, reloading;
    public Camera fpsCam;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public bool Active;

    [Header("Spread")]
    public float maxSpread = 0.1f;
    public float spread;
    public float spreadAddedByShot = 0.05f;
    public float regainSpreadPower = 0.5f;
    private float shootingSpread;
    private float movementSpread;

    [Header("Model")]
    public GameObject Equiped;
    public GameObject UnEquiped;

    [Header("Effect")]
    public int muzzleFlashEffectID;

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
    private Vector3 normalPos;
    public Vector3 aimPosition;

    [Header("Animation")]
    public Animation anim;

    [Header("UI")]
    public bool ShutGunShow;
}
