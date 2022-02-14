using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidController : MonoBehaviour
{
    Vector3 target;
    float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        SetNewTarget(new Vector3(
            transform.position.x,
            transform.position.y,
            transform.position.z - 10
        ));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) == true){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo)== true){
                SetNewTarget(new Vector3(hitInfo.point.x, transform.position.y, hitInfo.point.z));
            }
        }

        Vector3 direction = target - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
    }

    void SetNewTarget(Vector3 newTarget){
        target = newTarget;
        transform.LookAt(target);
    }
}
