using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShaderChange : MonoBehaviour
{
    Renderer rend;
    private Shader shader1;
    private Shader shader2;

    public void Start() {
        rend = GetComponent<Renderer> ();
        shader1 = Shader.Find("Standard");
        shader2 = Shader.Find("Diffuse");
    }

    public void changeShader() {
        if (rend.material.shader == shader1) {
            rend.material.shader = shader2;
        } else {
            rend.material.shader = shader1;
        }
        
    }
}
