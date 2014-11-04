using UnityEngine;
using System.Collections;

public class Morrer : MonoBehaviour 
{
	public int pontos;

	void OnCollisionEnter2D (Collision2D colisao) 
	{
		Arbitro.pontos += pontos;
		Destroy (gameObject);
		print ("Pontos geral: " + Arbitro.pontos);
	}
}
