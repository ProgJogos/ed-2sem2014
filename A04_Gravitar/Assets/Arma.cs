using UnityEngine;
using System.Collections;

public class Arma : MonoBehaviour {

	public GameObject bala;
	public float velocidade;

	public void Update () {
		// teste, APGAR DEPOIS
		/*
		if (Input.GetKeyDown (KeyCode.W)) {
			Disparar (transform.right);
		}
		*/
	}

	public void Disparar (Vector3 direcao)
	{
		GameObject tiro = Instantiate (
			bala,
			transform.position, 
		    Quaternion.identity) as GameObject;
		tiro.transform.right = direcao;
		tiro.GetComponent<Rigidbody2D>().velocity = 
			direcao * velocidade;
	}
}
