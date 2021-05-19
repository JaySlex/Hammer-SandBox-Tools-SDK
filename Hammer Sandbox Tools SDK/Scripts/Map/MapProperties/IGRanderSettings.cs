using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class IGRenderSettings
{
    public bool Fog;
    public Color fogColor;
    public float fogDensity;
    public Texture2D HaloTexture;
    [Range(0,1)]
    public float HaloStrength = 0.5f;
    public float FlareFadeSpeed;
    [Range(0, 1)]
    public float FlareStrength = 3f;

    public Light SunSource;
    public Material Skybox;

    public IGRenderSettings(bool Fog,Color fogColor, float fogDensity, Texture2D HaloTexture, float HaloStrength, float FlareFadeSpeed, float FlareStrength, Light SunSource, Material Skybox)
    {
        this.Fog = Fog;
        this.fogColor = fogColor;
        this.fogDensity = fogDensity;
        this.HaloTexture = HaloTexture;
        this.HaloStrength = HaloStrength;
        this.FlareFadeSpeed = FlareFadeSpeed;
        this.FlareStrength = FlareStrength;
        this.SunSource = SunSource;
        this.Skybox = Skybox;

    }
}
