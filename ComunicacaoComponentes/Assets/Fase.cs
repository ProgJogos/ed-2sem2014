using UnityEngine;
using System.Collections;

public class Fase : MonoBehaviour {

	public GameObject[] inimigos;

	void Start ()
	{
		inimigos = GameObject.FindGameObjectsWithTag ("Inimigo");
	}

	void InimigoMorreu () 
	{
		inimigos = GameObject.FindGameObjectsWithTag ("Inimigo");
		if (inimigos.Length == 0) {
			print ("A fase nao tem mais inimigos");
		}
	}
}
