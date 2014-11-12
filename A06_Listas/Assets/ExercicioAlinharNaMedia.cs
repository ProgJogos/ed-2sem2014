using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExercicioAlinharNaMedia : MonoBehaviour 
{
	public List<GameObject> lista;

	void Start () 
	{
		// calcula a media do componetne X da posicao dos objetos
		float media = 0;
		for (int i = 0; i < lista.Count; i++) 
		{
			media += lista[i].transform.position.x / lista.Count;
		}
		// aplica a nova posicao para os objetos
		foreach (GameObject objeto in lista) 
		{
			objeto.transform.position = new Vector3 (
				media,
				objeto.transform.position.y,
				objeto.transform.position.z
			);
		}
	}
}
