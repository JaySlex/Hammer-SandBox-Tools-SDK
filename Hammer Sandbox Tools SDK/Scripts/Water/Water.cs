using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Water/Water")]
public class Water : MonoBehaviour
{
    public WaterType waterType;

}

public enum WaterType
{
    water1,
    ocean1,
    custom
}

