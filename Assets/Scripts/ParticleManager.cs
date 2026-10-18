using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    ParticleSystem particleSys;
    public GameObject explosion;
    
    void Start()
    {
        particleSys = GetComponent<ParticleSystem>();
    }

    void PlayParticle() // faz as particulas começarem a surgir
    {
        particleSys.Play();
    }
    void StopParticle() // faz a particula parar
    {
        particleSys.Stop();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Felpudo") || collision.CompareTag("Fofura")) // caso felpudo ou fofura colidam com o objeto invisivel de onde surge as particulas, ele da play nas particulas
        {
            PlayParticle();
            Debug.Log("Oye como va");
        }
        if (collision.CompareTag("Meteor")) // se colidir com o meteoro, as particulas param
        {
            StopParticle();
            explosion.SetActive(true);
            Debug.Log("Dios mio");
        }
    }
}
