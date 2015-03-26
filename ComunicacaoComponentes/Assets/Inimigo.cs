using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	GameObject fase;

	void Start () {
		fase = GameObject.Find ("Fase");
	}
	
	void OnDestroy () {
		fase.SendMessage ("InimigoMorreu");
	}
}
