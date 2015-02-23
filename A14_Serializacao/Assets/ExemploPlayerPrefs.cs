using UnityEngine;
using System.Collections;

public class ExemploPlayerPrefs : MonoBehaviour {

	public int contador;

	void Start () {
		contador = PlayerPrefs.GetInt ("contador");
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			contador++;
			PlayerPrefs.SetInt("contador", contador);
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			PlayerPrefs.DeleteAll();
			contador = 0;
		}
	}
}
