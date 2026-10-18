using UnityEngine;
using System.Collections;

public class MoveFofura : MonoBehaviour
{
	public Vector3 moveSpeed;
	public float spawnTime = 2f;
	public float spawnDelay = 2f;
	  public bool isMoving = true;

	// Use this for initialization
	void Start()
	{
		moveSpeed = Vector3.left * Time.deltaTime;
		InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);
	}

	void ChangeSpeed()
	{
		moveSpeed = new Vector3(Random.Range(-1, -2), 0, 0) * 0.03f;
	}

	void StopSpeed() // função que desliga a chave de movimento do player
	{
		isMoving = false;
	}

	void Update()
	{
		if (isMoving) // se a chave que checa se o player esta se movendo for verdadeira, ele pode se movimentar
        {
            transform.position += moveSpeed; 
        }
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Felpudo")
		{
			StopSpeed(); // caso colida com o Felpudo, ele para de se mover
		}
	}
}