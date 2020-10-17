#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

public class AssetBundle : MonoBehaviour
{
    [MenuItem("Hammer SandBox Tools SDK/Build All Mods")]
    static void BuildBundles()
    {
        if (!Directory.Exists("Assets/Output")) Directory.CreateDirectory("Assets/Output");
        BuildPipeline.BuildAssetBundles("Assets/Output", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        EditorUtility.RevealInFinder("Assets/Output/Output");

    }

  
    
}
#endif