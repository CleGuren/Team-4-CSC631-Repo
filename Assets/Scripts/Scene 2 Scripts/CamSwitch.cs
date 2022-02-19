using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public Camera mainCamera;
    public Camera topDownCamera;
    public bool tdCameraEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = !tdCameraEnabled;
        topDownCamera.enabled = tdCameraEnabled;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("c")) {
            tdCameraEnabled = !tdCameraEnabled;
            mainCamera.enabled = !tdCameraEnabled;
            topDownCamera.enabled = tdCameraEnabled;
        }
    }
}
