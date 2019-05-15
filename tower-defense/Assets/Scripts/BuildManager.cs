
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one Buildmanager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject standardPrefab;

    private void Start()
    {
        turretToBuild = standardPrefab;
    }

    private GameObject turretToBuild;

    public GameObject GetBuildTurretToBuild()
    {
        return turretToBuild;
    }
}
