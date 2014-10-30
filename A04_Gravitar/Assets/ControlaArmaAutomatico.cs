using UnityEngine;
using System.Collections;

public class ControlaArmaAutomatico : MonoBehaviour 
{
	public Transform alvo;
	public float frequencia;
	public float margemErro;
	private float timer = 0;
	
	void Update () 
	{
		timer += Time.deltaTime;
		if (timer > frequencia)
		{
			timer = 0;
			Vector3 direcaoTiro = alvo.position - transform.position;
			direcaoTiro.x = Random.Range(-margemErro/2, margemErro/2);
			transform.GetComponent<Arma>().Disparar(direcaoTiro);
		}
	}
}
