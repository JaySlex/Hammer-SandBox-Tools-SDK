using UnityEditor;
using UnityEngine;
using System.IO;
using System.Diagnostics;

public class HTools : MonoBehaviour
{
    #region Map
    [MenuItem("Hammer SandBox Tools SDK/Map/Empty Map")]
    static void EmptyMap()
    {
        GameObject go = new GameObject("EmptyMap");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<MapProperties>();
    }

    [MenuItem("Hammer SandBox Tools SDK/Map/Light Map")]
    static void LightMap()
    {
        GameObject go = new GameObject("Map:");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<MapProperties>();
        go.AddComponent<LightDataUpdate>();
    }
    [MenuItem("Hammer SandBox Tools SDK/Map/NavMesh Map")]
    static void NavMeshMap()
    {
        GameObject go = new GameObject("Map:");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<MapProperties>();
        go.AddComponent<NavMeshUpdate>();
    }
    [MenuItem("Hammer SandBox Tools SDK/Map/Light + NavMesh Map")]
    static void LightNavMeshMap()
    {
        GameObject go = new GameObject("Map:");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<MapProperties>();
        go.AddComponent<NavMeshUpdate>();
        go.AddComponent<LightDataUpdate>();
    }


    [MenuItem("Hammer SandBox Tools SDK/Map/Components/Spawn Player")]
    static void PlayerSpawn()
    {
        GameObject go = new GameObject("PlayerSpawn");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<Spawn>();

  
    }

    [MenuItem("Hammer SandBox Tools SDK/Map/Components/Spawn AI")]
    static void SpawnAI()
    {
        GameObject go = new GameObject("AISpawn");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<SpawnAi>();
    }

    [MenuItem("Hammer SandBox Tools SDK/Map/Components/Spawn Item")]
    static void SpawnItem()
    {
        GameObject go = new GameObject("ItemSpawn");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<SpawnItem>();
    }

    #endregion

    #region Props

    [MenuItem("Hammer SandBox Tools SDK/Props/New Static Prop")]
    static void SpawnStaticProp()
    {
        GameObject go = new GameObject("Prop");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<SyncProps>();
        go.AddComponent<Grabs>();
        go.AddComponent<Rigidbody>();
        go.GetComponent<Rigidbody>().isKinematic = true;
    }

    [MenuItem("Hammer SandBox Tools SDK/Props/New Physics Prop")]
    static void SpawnPhysicsProp()
    {
        GameObject go = new GameObject("Prop");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<SyncProps>();
        go.AddComponent<Grabs>();
        go.AddComponent<Rigidbody>();
        go.GetComponent<Rigidbody>().isKinematic = false;
    }



    #endregion

    #region Item

    [MenuItem("Hammer SandBox Tools SDK/Item/Legacy Weapon")]
    static void SpawnLegacyWeapon()
    {
        GameObject go = new GameObject("Legacy Weapon");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<Weapon>();
        go.AddComponent<BoxCollider>();
        go.AddComponent<Rigidbody>();
        go.AddComponent<AudioSource>();

    }


    [MenuItem("Hammer SandBox Tools SDK/Item/New Weapon")]
    static void SpawnNewWeapon()
    {
        GameObject go = new GameObject("New Weapon");
        go.transform.position = new Vector3(0, 0, 0);
        go.AddComponent<Weapon>();
        go.AddComponent<Rigidbody>();

    }


    #endregion

    #region Launch Game
    [MenuItem("Hammer SandBox Tools SDK/Export/Options/Locate Game .EXE")]
    public static void LocateGame()
    {
        string[] filters = new string[]
        {
            "Application",
            "exe"
        };
        
        string path = EditorUtility.OpenFilePanelWithFilters("Hammer sandBox exe","",filters);
        if (File.Exists(path))
        {
            File.WriteAllText("./gameexepath.txt", path);
        }
    }

    public static void LaunchGame()
    {

        if (File.Exists("./gameexepath.txt"))
        {
            if (File.Exists(File.ReadAllText("./gameexepath.txt")))
            {
                Process.Start(File.ReadAllText("./gameexepath.txt"), "");
            }
        }
        else
        {
            if (EditorUtility.DisplayDialog("Hammer SandBox SDK", "Please locate the game exe before trying launching it. It should be in your steamapp folder.", "Locate Game exe", "Cancel"))
            {
                LocateGame();
            }
        }
    }


    [MenuItem("Hammer SandBox Tools SDK/Export/Options/Launch game after export")]
    static void ToggleLaunchGameAfterExport()
    {
        LaunchGameAfterExport = !LaunchGameAfterExport;
    }

    [MenuItem("Hammer SandBox Tools SDK/Export/Options/Launch game after export", true)]
    static bool ToggleLaunchGameAfterExportValidate()
    {
        Menu.SetChecked("Hammer SandBox Tools SDK/Export/Options/Launch game after export", LaunchGameAfterExport);
        return true;
    }

    public static bool LaunchGameAfterExport
    {
        get{ return EditorPrefs.GetBool("Launch_game_after_export", true); }
        set {EditorPrefs.SetBool("Launch_game_after_export", value); }
    }
    #endregion

    #region ChangeExportfolder
    [MenuItem("Hammer SandBox Tools SDK/Export/Options/Change Export Folder")]
    public static void ChangeExportFolder()
    {
        string path = EditorUtility.OpenFolderPanel("Hammer sandBox exe", "", "");
        File.WriteAllText("./exportPath.txt", path);
    }
    #endregion
}
