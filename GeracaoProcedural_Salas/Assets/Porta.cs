using UnityEngine;
using System.Collections;

public class Porta : MonoBehaviour {
	public Sala sala;
	public Sala proxSala;
	public Vector3 offsetSala;

	public void Inicializar() {
		proxSala = null;
		sala = transform.parent.GetComponent<Sala> ();
		offsetSala = sala.transform.position - transform.position;
	}
}
