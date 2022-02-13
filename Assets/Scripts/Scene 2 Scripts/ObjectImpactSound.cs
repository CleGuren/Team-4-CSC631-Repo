using UnityEngine;

public class ObjectImpactSound : MonoBehaviour
{
    public AudioSource impactSound;

    void OnCollisionEnter(Collision collision) {
        GetComponent<AudioSource> ().Play();
    }
}
