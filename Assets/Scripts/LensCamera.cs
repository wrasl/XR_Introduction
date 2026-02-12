using UnityEngine;

public class LensCamera : MonoBehaviour
{
    
    public Transform playerCamera;

    void Update()
    {
        transform.rotation = playerCamera.rotation;
    }
}
