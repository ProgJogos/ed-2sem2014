using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PersonagemSelecionavel : MonoBehaviour {

	public Text txtNome;
	public Image imgSelecionado;
	public bool selecionado;

	void Start () {
		selecionado = false;
	}
	
	void Update () {
		imgSelecionado.enabled = selecionado;
	}

	void OnMouseDown () {
		selecionado = !selecionado;
		txtNome.text = gameObject.name;
	}
}
