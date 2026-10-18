using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    ParticleSystem particleSys;
    
    void Start()
    {
        particleSys = GetComponent<ParticleSystem>();
    }

    void PlayParticle()
    {
        particleSys.Play();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Felpudo") || collision.CompareTag("Fofura"))
        {
            PlayParticle();
            Debug.Log("Oye como va");
        }
    }
}
