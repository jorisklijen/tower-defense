using UnityEngine;
using UnityEngine.Audio;

public class NodeScript : MonoBehaviour
{
    public Material hoverColor;
    public Material normalColor;
    public Material occupiedColor;

    public Vector3 offset;

    public AudioSource turretPlacementSource;

    private GameObject turret;

    private Renderer rend;

    private bool isBuildOn;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = normalColor;
    }

    private void OnMouseDown()
    {
        //build a turret
        if(turret != null) Debug.Log("Can't build here");
        if (isBuildOn == false)
        {
            isBuildOn = true;
            GameObject turretToBuild = BuildManager.instance.GetBuildTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position + offset, transform.rotation);
            turretPlacementSource.Play();
        }
    }

    private void OnMouseEnter()
    {
        if (isBuildOn == true)
        {
            rend.material = occupiedColor;
            return;
        }

        rend.material = hoverColor;
        //Debug.Log("Mouse Enter");
    }

    private void OnMouseExit()
    {
        rend.material = normalColor;
        //Debug.Log("Mouse Exit");
    }
}
