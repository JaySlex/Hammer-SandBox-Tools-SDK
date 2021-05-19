using UnityEngine;
[AddComponentMenu("Hammer SandBox Tools SDK/Items/Weapons/LegacyWeapon")]
public class Weapon : ItemP
{
    [Header("IK")]
    public Transform IKLeft;
    public Transform IKRight;

    [Header("Weapon")]
    public GameObject MuzzleFlash;
    public GameObject Projectil;
    public GameObject ProjectilFromPlayer;
    public float firerate = 0.5f;
    public float force;
    public float SelfForce;
    private float nextfire = 0f;
    public Transform eject;
    public bool ShutGun;
    private Animation anim;

    [Header("Sway")]
    public float amount;
    public float maxAmount;
    public float smoothAmount;
    public float MoveAmount;
    public float MoveMaxAmount;
    public float MoveSmoothAmount;
    private Vector3 initialPos;

    private AudioSource source;
}
