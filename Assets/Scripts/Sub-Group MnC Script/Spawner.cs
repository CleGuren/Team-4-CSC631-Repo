using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    public InputAction action;
    public GameObject ObjectToCopy;
    private Camera cam = null;

    public void Spawn() {
        Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {
            Instantiate(ObjectToCopy, hit.point, Quaternion.identity);
        }
    }
    
    private void OnEnable() {
        action.Enable();
    }

    private void OnDisable() {
        action.Disable();
    }
    
    void Start() {
        cam = Camera.main;
        action.performed += _ => Spawn();
    }
}
