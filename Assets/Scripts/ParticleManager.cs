using System.Collections;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    ParticleSystem particleSys;
    public Rigidbody2D meteorRigidBody;
    public Animator fadeAnimation;
    [Header("Game Objects")]
    public GameObject explosionGameObject;
    public GameObject felpudoGameObject;
    public GameObject fofuraGameObject;
    public GameObject meteor;

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

    IEnumerator WaitMeteor(float waitTime)
    {
        yield return new WaitForSeconds(waitTime); // espera um tempo determinado e toca tudo abaixo
        Debug.Log("O meteoro vai cair ó");
        meteorRigidBody.constraints = RigidbodyConstraints2D.None; // quando a 'courrotine' é chamada, libera os eixos do meteoro
        meteorRigidBody.WakeUp(); // acorda o rigidBody do meteoro para que ele possa cair
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Felpudo") || collision.CompareTag("Fofura")) // caso felpudo ou fofura colidam com o objeto invisivel de onde surge as particulas, ele da play nas particulas
        {
            PlayParticle();
            StartCoroutine(WaitMeteor(2f));
            Debug.Log("Oye como va");
        }
        if (collision.CompareTag("Meteor")) // se colidir com o meteoro, as particulas param
        {
            StopParticle();
            explosionGameObject.SetActive(true); // ativa a explosão
            felpudoGameObject.SetActive(false); // mata felpudo. RIP D:
            fofuraGameObject.SetActive(false); // mata fofura. RIP D:
            meteor.SetActive(false); // destroi o meteoro
            fadeAnimation.SetBool("isFading", true);
            Debug.Log("Dios mio");
        }
    }
}
