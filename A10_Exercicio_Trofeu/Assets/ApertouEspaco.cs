using UnityEngine;
using System.Collections;

public class ApertouEspaco : MonoBehaviour {

	public static event TratarEvento apertouEspaco;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			// disparar o evento
			if(apertouEspaco != null)
			{
				apertouEspaco(" ");
			}
		}
	}
}
