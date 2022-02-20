using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public GameObject obj;
    public Material[] material = new Material[2];
    void Start()
    {
        obj.GetComponent<MeshRenderer>().material = material[0];
    }

    public void changeSphere() {
        obj.GetComponent<MeshRenderer>().material = material[1];
    }
}
