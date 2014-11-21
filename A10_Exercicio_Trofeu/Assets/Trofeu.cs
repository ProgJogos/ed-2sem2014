using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Trofeu : MonoBehaviour 
{
	public Dictionary<string, string> trofeus;
	public string sequencia;

	void Start () 
	{
		// registrei no evento clicou
		Clicavel.clicou += AumentarSequencia2;
		ApertouEspaco.apertouEspaco += AumentarSequencia2;

		trofeus = new Dictionary<string, string> ();
		trofeus.Add ("AA", "Alcoolicos Anonimos");
		trofeus.Add ("AAA", "Triplo A");
	}

	void OnDestroy ()
	{
		// desregistrar observador
		Clicavel.clicou -= AumentarSequencia2;
		ApertouEspaco.apertouEspaco -= AumentarSequencia2;
	}

	void AumentarSequencia (string novo)
	{
		sequencia += novo;
		string msg;
		if (trofeus.TryGetValue (sequencia, out msg)) 
		{
			Debug.Log ("Trofeu: " + msg);
		}
		else 
		{
			Debug.Log ("Nao existe trofeu apra essa sequencia.");
		}

	}

	void AumentarSequencia2 (string novo)
	{
		sequencia += novo;

		if (sequencia.Length > 1) 
		{
			// terminei uma sequencia
			if(novo[0] == sequencia[0])
			{
				string msg;
				if (trofeus.TryGetValue (sequencia, out msg)) 
				{
					Debug.Log ("Trofeu: " + msg);
				}
				else 
				{
					Debug.Log ("Nao existe trofeu apra essa sequencia.");
				}
				sequencia = "";
			}
		}	
	}
}
