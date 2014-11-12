using UnityEngine;
using System.Collections;

public class ExemploDelegate : MonoBehaviour 
{
	public delegate void Agir ();

	public int saude;
	public Agir acao;
	
	void Update () 
	{
		acao = Atacar;
		acao += Fugir;
		acao += Atacar;
		acao -= Fugir;
		/*
		if (saude > 50) 
		{
			acao = Atacar;
		} 
		else 
		{
			acao = Fugir;
		}
		*/


		if (acao != null) 
		{
			acao();
		}
	}

	void Fugir () 
	{
		print("Fugir!");
	}

	void Atacar ()
	{
		print("Atacar!");
	}
}
