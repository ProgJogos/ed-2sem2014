using UnityEngine;
using System.Collections;

public class ItemColetavel : MonoBehaviour 
{
	public bool coletar;
	public float intervalo;
	private float timer;
	public int quantidade;

	void OnTriggerEnter2D (Collider2D outro)
	{
		if(outro.gameObject.name == "Jogador") {
			timer = 0;
			coletar = false;
		}
	}
	
	void OnTriggerStay2D (Collider2D outro)
	{
		if(outro.gameObject.name == "Jogador") {
			timer += Time.deltaTime;
			if (timer > intervalo) {
				coletar = true;
				outro.GetComponent<MotorJogador>().combustivel += quantidade;
				Destroy (gameObject);
			}
		}
	}

}
