#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;

public class AssetBundle : MonoBehaviour
{
    [MenuItem("Hammer SandBox Tools SDK/Export/Build Assets")]
    static void BuildBundles()
    {
        if (!File.Exists("./exportPath.txt"))
        {
            if (!Directory.Exists("Assets/Output")) Directory.CreateDirectory("Assets/Output");
            BuildPipeline.BuildAssetBundles("Assets/Output", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
            EditorUtility.RevealInFinder("Assets/Output/Output");
        }
        else
        {
            string path = File.ReadAllText("./exportPath.txt");
            if (Directory.Exists(path))
            {
                BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
                EditorUtility.RevealInFinder(path);
            }
            else
            {
                if (!Directory.Exists("Assets/Output")) Directory.CreateDirectory("Assets/Output");
                BuildPipeline.BuildAssetBundles("Assets/Output", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
                EditorUtility.RevealInFinder("Assets/Output/Output");
            }
        }
        if (HTools.LaunchGameAfterExport)
        {
            HTools.LaunchGame();
        }

    }

  
    
}
#endif