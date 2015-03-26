using UnityEngine;
using System.Collections;

public class GeradorArma : MonoBehaviour {

	[Range(6, 14)]
	public int pontos;

	public Arma arma;
	
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			arma = new Arma(pontos);
		}
	}
}
