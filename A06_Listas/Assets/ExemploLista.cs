using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExemploLista : MonoBehaviour 
{
	List<string> palavras;
		
	void Start () 
	{
		print (palavras); // Null
		palavras = new List<string> ();
		print (palavras); // List

		print (palavras.Count); // 0
		palavras.Add ("bob");
		print (palavras.Count); // 1
		palavras.Add ("ana");
		palavras.Add ("carlos");
		print (palavras.Count); // 3
		print (palavras[0]); // bob
		// print (palavras [10]); // erro
		palavras.Remove("bob");
		print (palavras[0]); // ana
		print (palavras.Remove ("bob")); // false
		print ( palavras.Contains("zeh") ); // false

		//string resultado = palavras.Find(atual => (atual.Length  > 3));
		//int resultado = palavras.FindIndex(atual => (atual.Length  > 3));
		palavras.Add ("joao");
		List<string> resultado = palavras.FindAll (
			atual => 
			atual.Length > 3
		);
		print (resultado.Count);
	}
}
