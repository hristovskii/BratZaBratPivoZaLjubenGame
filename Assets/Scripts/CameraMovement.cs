using UnityEngine;

public class Camera : MonoBehaviour
{
    public float cameraSpeed;

    void Update()
    {
        transform.position = new Vector3(cameraSpeed * Time.deltaTime + transform.position.x, 0, 0);
    }
}
