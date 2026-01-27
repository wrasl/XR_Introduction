using UnityEngine;
using UnityEngine.InputSystem;

public class PointLightController : MonoBehaviour
{
    public InputActionReference action; 
    public Light pointLight;

    // Let's make some extra colors so we can keep switching the light
    public Color[] colors = {Color.red, Color.green, Color.blue, Color.cyan, Color.white};
    private int currIndex = 0;

    void Start()
    {
        pointLight = GetComponent<Light>();

        action.action.Enable();

        action.action.performed += OnButtonPressed;
    }

    private void OnButtonPressed(InputAction.CallbackContext ctx)
    {

        pointLight.color = colors[currIndex];
        currIndex = (currIndex + 1) % colors.Length;
    }
}
