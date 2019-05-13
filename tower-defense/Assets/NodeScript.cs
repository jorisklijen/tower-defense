using UnityEngine;

public class NodeScript : MonoBehaviour
{
    public Material hoverColor;
    public Material normalColor;

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = normalColor;
    }

    private void OnMouseEnter()
    {
        rend.material = hoverColor;
        //Debug.Log("Mouse Enter");
    }

    private void OnMouseExit()
    {
        rend.material = normalColor;
        //Debug.Log("Mouse Exit");
    }
}
