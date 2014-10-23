using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class Movimento : MonoBehaviour 
{
	public Vector2 direcaoAlvo;
	public float aceleracao;
	public float velocidadeMaxima;
	
	void FixedUpdate () 
	{
		if (direcaoAlvo.magnitude > 0.05f) 
		{
			transform.right = direcaoAlvo;
		}
		if (rigidbody2D.velocity.magnitude < velocidadeMaxima) 
		{
			rigidbody2D.AddForce(
				transform.right * 
				aceleracao *
				direcaoAlvo.magnitude);
		}
		Debug.DrawRay (transform.position, 
		              transform.right, 
		              Color.red);
	}
}
