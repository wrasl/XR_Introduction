using UnityEngine;

public class LensCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera magCamera;

    void LateUpdate()
    {
        if (!mainCamera || !magCamera) return;

        magCamera.transform.position = transform.position;
        magCamera.transform.rotation = mainCamera.transform.rotation;
    }
}