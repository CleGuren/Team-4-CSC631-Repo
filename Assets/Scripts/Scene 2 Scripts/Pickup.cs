using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform destination;
    private Rigidbody item; 
    void OnMouseDown() {
        item = GetComponent<Rigidbody>();
        item.useGravity = false;
        this.transform.position = destination.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }

    void OnMouseUp() {
        this.transform.parent = null;
        item.useGravity = true;
    }
}
