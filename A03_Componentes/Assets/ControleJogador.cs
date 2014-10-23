using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Movimento))]
public class ControleJogador : MonoBehaviour 
{
	void Update () 
	{
		Vector2 direcaoInput = new Vector2 (
			Input.GetAxis ("Horizontal"),
			Input.GetAxis ("Vertical"));
		this.GetComponent<Movimento>().direcaoAlvo = direcaoInput;
	}
}
