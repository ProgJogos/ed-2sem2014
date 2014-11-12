using UnityEngine;
using System.Collections;

public class ControlaArmaJogador : MonoBehaviour 
{
	void Update () 
	{
		if (Input.GetButtonDown ("Atirar")) 
		{
			transform.GetComponent<Arma>().Disparar(transform.right);
		}
	}
}
