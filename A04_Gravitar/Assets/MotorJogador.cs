using UnityEngine;
using System.Collections;

public class MotorJogador : MonoBehaviour 
{

	public float velocidadeRotacao;
	public float velocidadeMaxima;
	public float forcaFoguete;
	public float combustivel;
	public float consumoCombustivel;
	private bool fogueteLigado;

	void Update () 
	{
		// captura direcao input
		Vector3 controle = new Vector2 (
			Input.GetAxis("Horizontal"),
	        Input.GetAxis("Vertical")
	    );
	    // gira
      	transform.right = Vector2.Lerp(
      		transform.right, 
      		controle, 
      		velocidadeRotacao * Time.deltaTime);
      	// estah apertando o botao do foguete?
      	if (Input.GetButton("Foguete")) {
      		fogueteLigado = true;
      	}
      	else {
      		fogueteLigado = false;
      	}
	}
	
	void FixedUpdate ()
	{
		if(combustivel >= consumoCombustivel && fogueteLigado) {
			// visual de foguete ligado
			combustivel -= consumoCombustivel;
			// aplicar a fisica do foguete
			if (rigidbody2D.velocity.magnitude < velocidadeMaxima) {
				rigidbody2D.AddForce(transform.right * forcaFoguete);
			}
		}
	}
}
