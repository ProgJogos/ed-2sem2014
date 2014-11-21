using UnityEngine;
using System.Collections;

public class ContarCliques : MonoBehaviour {

	public Transform alvo;
	public int contagem;

	void Start () {
		contagem = 0;
		Clicavel.clicou += Somar;
	}

	void Somar (Transform t) 
	{
		if(t == alvo) contagem++;
		Debug.Log ("clicou em " + t.name);
		if (contagem == 10) {
			Clicavel.clicou -= Somar;
		}
	}
}
