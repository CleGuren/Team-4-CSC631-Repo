using UnityEngine;
using UnityEngine.InputSystem;

public class CameraAnimationScript : MonoBehaviour
{

    [SerializeField]
    private InputAction action;    
    private Animator animator;
    private bool ThreeDView = true;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void OnEnable() {
        action.Enable();
    }

    private void OnDisable() {
        action.Disable();
    }
    
    void Start()
    {
        action.performed += _ => SwitchState();
    }

    private void SwitchState() {
        if (ThreeDView) {
            animator.Play("2D View");
        } else {
            animator.Play("3D View");
        }

        ThreeDView = !ThreeDView;

    }
}
