using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Map/LightDataUpdate")]
public class LightDataUpdate : MonoBehaviour
{

    public LightMapData[] _lightMaps;


    [Header("RenderSettings")]
    public bool useCustomrenderSettings;
    public IGRenderSettings renderSettings;

    
}
[System.Serializable]
public class LightMapData
{
    public Texture2D lightmapDir;
    public Texture2D lightmapColor;
    public Texture2D shadowMask;

    public LightMapData(Texture2D lightmapDir, Texture2D lightmapColor, Texture2D shadowMask)
    {
        this.lightmapDir = lightmapDir;
        this.lightmapColor = lightmapColor;
        this.shadowMask = shadowMask;
    }
}
