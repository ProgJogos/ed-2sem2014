using UnityEngine;
using System.Collections;

public class TrocarCor : MonoBehaviour {

	// registrar-se ao evento
	void Start ()
	{
		Notificador.apertouEspaco += Trocar;
	}

	// desligar-se do evento
	void OnDestroy ()
	{
		Notificador.apertouEspaco -= Trocar;
	}

	// funcao que sera executada
	void Trocar () 
	{
		renderer.material.color = new Color (
			Random.value,
			Random.value,
			Random.value);
	}


}
