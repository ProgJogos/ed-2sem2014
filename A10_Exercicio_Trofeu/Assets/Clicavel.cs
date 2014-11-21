using UnityEngine;
using System.Collections;

public delegate void TratarEvento (string msg);

public class Clicavel : MonoBehaviour {

	public string texto;
	// definir evento clicou

	public static event TratarEvento clicou;

	void OnMouseDown ()
	{
		// print ("clicou");
		if (clicou != null) 
		{
			clicou(texto);
		}
	}

}
