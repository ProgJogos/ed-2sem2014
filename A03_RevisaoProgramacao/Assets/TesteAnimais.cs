using UnityEngine;
using System.Collections;

public class TesteAnimais : MonoBehaviour 
{
	void Start () {
		Animal cao = new Animal("rex", 50.5f);
		Debug.Log (cao.nome);
		cao.Descrever();
		
		Gato bichano = new Gato	("garfield", 20f, 7);
		bichano.Descrever();
		bichano.Miar();
		
		PeixeBoi bicho = new PeixeBoi ("Bolinha");
		bicho.Descrever();
		bicho.Nadar();
		bicho.Ruminar();
		bicho.Descrever();
	}
}
