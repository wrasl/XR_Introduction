using UnityEngine;
using UnityEngine.InputSystem;

public class PointLightController : MonoBehaviour
{
    public InputActionReference action; 
    public Light pointLight;

    void Start()
    {
        // Get the existing Light component on this GameObject
        pointLight = GetComponent<Light>();

        // Enable the input action
        action.action.Enable();

        // Subscribe to button press
        action.action.performed += OnButtonPressed;
    }

    private void OnButtonPressed(InputAction.CallbackContext ctx)
    {
        // Example: change color
        pointLight.color = Color.cyan;
    }
}
