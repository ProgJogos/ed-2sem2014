using UnityEngine;
using System.Collections;

public class Notificador : MonoBehaviour {

	public delegate void TratamentoDeEventoComMsg (string msg);
	public delegate void TratamentoDeEventoSimples ();
	// eventos
	public static event TratamentoDeEventoSimples apertouEspaco;
	public static event TratamentoDeEventoSimples clicou;

	public static event TratamentoDeEventoComMsg apertouTeclaR;

	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			// disparar evento apertouEspaco
			if(apertouEspaco != null) 
			{
				apertouEspaco();
			}
			
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			if (apertouTeclaR != null) apertouTeclaR(
				Time.realtimeSinceStartup.ToString());
		}

		// dispara clicou quando clicar em qualquer lugar
		if (Input.GetMouseButtonDown (0)) {
			if(clicou != null) clicou();
		}
	}
}
