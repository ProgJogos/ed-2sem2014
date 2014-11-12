using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Movimento))]
public class ControleIA : MonoBehaviour 
{
	public GameObject alvo;

	void Update () 
	{
		Vector2 direcao = new Vector2 (
			(alvo.transform.position - this.transform.position).x,
			(alvo.transform.position - this.transform.position).y);
		this.GetComponent<Movimento>().direcaoAlvo = direcao;
		Debug.DrawRay (transform.position, direcao, Color.yellow);
	}
}
