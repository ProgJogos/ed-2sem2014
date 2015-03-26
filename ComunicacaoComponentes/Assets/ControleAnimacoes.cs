using UnityEngine;
using System.Collections;

public class ControleAnimacoes : MonoBehaviour {

	Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}

	public void Colidiu () {
		anim.SetTrigger ("Machucou");
	}

	public void DestruirObjeto() 
	{
		Destroy (transform.parent.gameObject);
	}
}
