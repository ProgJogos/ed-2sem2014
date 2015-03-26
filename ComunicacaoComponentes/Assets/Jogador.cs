using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour {
	/*
	MeshRenderer rend;

	void Start() {
		rend = GetComponentInChildren<MeshRenderer> ();
	}

	void OnCollisionEnter () {
		rend.enabled = false;
	}
	*/

	void OnCollisionEnter()
	{
		BroadcastMessage ("Colidiu");
	}
}
