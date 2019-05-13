using UnityEngine;

public class NodeScript : MonoBehaviour
{
    public Color hoverColor;
    public Color normalColor;

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnMouseEnter()
    {
        rend.material.SetColor("_Color", hoverColor);
        Debug.Log("Mouse Enter");
    }

    private void OnMouseExit()
    {
        rend.material.SetColor("_Color", normalColor);
        Debug.Log("Mouse Exit");
    }
}
