using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public ParticleSystem particleEffect;

     void OnCollisionEnter(Collision collision) {
        particleEffect.Play();
    }
}
