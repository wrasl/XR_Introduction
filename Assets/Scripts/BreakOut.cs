using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public InputActionReference action; 
    public Transform Room;
    public Transform ExternalPlatform;

    public bool flag = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = Room.position;
        transform.rotation = Room.rotation;

        action.action.Enable();

        action.action.performed += (ctx) => { OnButtonPressed(); };
    }

    private void OnButtonPressed()
    {
        if (flag)
        {
            transform.position = Room.position;
            transform.rotation = Room.rotation;
        }
        else
        {
            transform.position = ExternalPlatform.position;
            transform.rotation = ExternalPlatform.rotation;
        }

        flag = !flag;
    }
}
