using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotationSpeed = 30f;

    void Update()
    {
        // Rotate around the Y axis using real time
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
