using UnityEditor;
using UnityEngine;

public class Tools : MonoBehaviour
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
}
