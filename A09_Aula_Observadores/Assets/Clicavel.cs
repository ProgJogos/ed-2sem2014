using UnityEngine;
using System.Collections;

public class Clicavel : MonoBehaviour {

	public delegate void TratarClique (Transform t);

	public static event TratarClique clicou;

	void OnMouseDown () 
	{
		// disparar um evento
		if (clicou != null)	clicou (transform);
	}
}
