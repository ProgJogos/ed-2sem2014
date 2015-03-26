using UnityEngine;
using System.Collections;

public class ControleSom : MonoBehaviour {

	AudioSource som;

	void Start() {
		som = GetComponent<AudioSource> ();
	}

	public void Colidiu () {
		som.Play ();
	}
}
