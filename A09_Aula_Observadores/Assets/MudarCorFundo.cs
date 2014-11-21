using UnityEngine;
using System.Collections;

public class MudarCorFundo : MonoBehaviour {
	
	// registrar-se ao evento
	void Start ()
	{
		Notificador.apertouEspaco += Mudar;
		Notificador.apertouTeclaR += MudarComMsg;
	}
	
	// desligar-se do evento
	void OnDestroy ()
	{
		Notificador.apertouEspaco -= Mudar;
		Notificador.apertouTeclaR -= MudarComMsg;
	}
	
	// funcao que sera executada
	void Mudar () 
	{
		Camera.main.backgroundColor = new Color (
			Random.value,
			Random.value,
			Random.value);
	}

	// funcao que sera executada
	void MudarComMsg (string msg) 
	{
		Camera.main.backgroundColor = new Color (
			Random.value,
			Random.value,
			Random.value);
		Debug.Log ("trocou de cor em: " + msg);
	}
	
	
}
