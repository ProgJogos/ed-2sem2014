using UnityEngine;
using System.Collections;

public delegate	void TratarEvento<T> (T dados);

public class GeradorEventos : MonoBehaviour
{
	public static event TratarEvento<Transform> clicou;
	
	void OnMouseDown ()
	{
		if (clicou != null) {
			clicou (transform);
		}
	}
}
