using UnityEngine;
using System.Collections;

public class TomarDano : MonoBehaviour {

	public float dano;
	
	void OnCollisionStay2D () 
	{
		GetComponent<MotorJogador>().combustivel -= dano;
		if (GetComponent<MotorJogador>().combustivel <= 0)
		{
			Destroy(gameObject);
		}
	}
}
