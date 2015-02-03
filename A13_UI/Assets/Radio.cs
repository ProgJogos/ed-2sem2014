using UnityEngine;
using System.Collections;

public class Radio : MonoBehaviour {

	public void Tocar(AudioClip musica) {
		audio.Stop ();
		audio.clip = musica;
		audio.Play();
	}

	public void MudarVolume (float valor) {
		audio.volume = valor;
	}

	public void TocarTecla(AudioClip som) {
		audio.Stop ();
		audio.clip = som;
		audio.volume = 0.2f;
		audio.Play();
	}
}
