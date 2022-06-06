using UnityEngine;

public class ItemP : Entity
{
    [Header("CustomItem")]
    public Sprite item_img;
    public ItemType item_type;

    [Header("Item")]
    public bool AI;
    public bool Active;

    [Header("Model")]
    public GameObject Equiped;
    public GameObject UnEquiped;
    public Transform leftIK;
}
public enum ItemType
{
    none,
    rifle,
    pistol,
    knife,
    sword
}