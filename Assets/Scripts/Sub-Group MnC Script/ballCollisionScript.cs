using UnityEngine;

public class ballCollisionScript : MonoBehaviour
{
    public ParticleSystem particleEffect;
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Wall") {
            Debug.Log("We hit a wall");
            particleEffect.Play();
        }
    }
}
