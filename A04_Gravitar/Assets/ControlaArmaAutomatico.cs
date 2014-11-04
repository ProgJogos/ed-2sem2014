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
		if (timer > frequencia && alvo != null)
		{
			timer = 0;
			Vector2 distanciaParaAlvo = Random.insideUnitCircle * 
				margemErro;
			Vector3 erro = alvo.position + new Vector3(
				distanciaParaAlvo.x,
				distanciaParaAlvo.y);
			Vector3 mira = erro - transform.position;
			transform.GetComponent<Arma>().Disparar(mira.normalized);
		}
	}
}
