using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Movimento))]
public class ControleDirecaoAleatoria : MonoBehaviour {
	void Start () {
		Vector2 direcao = Random.insideUnitCircle.normalized;
		this.GetComponent<Movimento> ().direcaoAlvo = direcao;
	}
}
