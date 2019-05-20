using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public float panSpeed = 30f;
    public float panBorderThickness = 10f;
    public float scrollSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) /*|| Input.mousePosition.y >= Screen.height - panBorderThickness*/)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S)/* || Input.mousePosition.y <= Screen.height - panBorderThickness*/)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A)/* || Input.mousePosition.x <= Screen.width - panBorderThickness*/)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D)/* || Input.mousePosition.x >= Screen.width - panBorderThickness*/)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }

        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            transform.Translate(Vector3.forward * scrollSpeed * Time.deltaTime);
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.Translate(Vector3.back * scrollSpeed * Time.deltaTime);
        }
    }
}
