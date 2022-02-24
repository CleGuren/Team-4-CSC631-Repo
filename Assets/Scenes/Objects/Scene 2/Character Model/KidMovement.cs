using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class KidMovement : MonoBehaviour
{
    public Camera mainCamera;
    private RaycastHit hit;
    private NavMeshAgent agent;
    private string groundTag = "Ground";
    private Animator animator;
    private Rigidbody kid;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent <NavMeshAgent>();
        animator = GetComponent<Animator>();
        kid = GetComponent<Rigidbody>();
    }
    
    

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.rightButton.isPressed){
            Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            animator.SetBool("isMoving", true);
            
            if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
                if(hit.collider.CompareTag(groundTag)){
                    agent.SetDestination(hit.point);
                }
            }
        }
        else{
            animator.SetBool("isMoving", false);
            kid.isKinematic = true;
        }
    }
}
