using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
        if(Input.GetMouseButtonDown(1)){
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
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
