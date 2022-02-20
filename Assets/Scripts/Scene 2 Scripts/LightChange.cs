using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour
{
    Light sun;

    void Start() {
        sun = GetComponent<Light> ();
    }

    // Update is called once per frame
    public void toggleLight()
    {
        sun.enabled = !sun.enabled;
    }
}
