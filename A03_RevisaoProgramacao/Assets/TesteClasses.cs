using UnityEngine;
using System.Collections;

public class TesteClasses : MonoBehaviour 
{
	public Pessoa pessoa1;
	public Pessoa pessoa2;
	
	void Start () 
	{
		pessoa1 = new Pessoa("bob", 7, pessoa2);
		pessoa2 = new Pessoa("zeh", 55, pessoa1);
		pessoa1.rival = pessoa2;
		// pessoa1.Respirar();
		pessoa1.AtacarSeuRival(40);
		
		Item livro = new Item("manual dos escoteiros", 10.5f);
		Arma espada = new Arma("excalibur", 100f);
		Item banana = new Item("banana");
		print (espada.preco);
		print (livro.Descrever());
		print (espada.Descrever());
	}
	
	void Update () {
		pessoa1.Envelhecer();
		pessoa2.Envelhecer();
		// print(pessoa1.Experiencia);
	}
}
