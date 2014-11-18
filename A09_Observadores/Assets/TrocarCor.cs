using UnityEngine;
using System.Collections;

public class TrocarCor : MonoBehaviour
{
	void Start ()
	{
		GeradorEventos.clicou += Trocar;
	}
	
	void OnDestroy ()
	{
		GeradorEventos.clicou -= Trocar;
	}
	
	void Trocar (Transform obj)
	{
		Color cor = new Color (Random.value, Random.value, Random.value);
		//Camera.main.backgroundColor = cor;
		obj.renderer.material.color = cor;
		Debug.Log ("Trocou cor.");
	}
}
