using UnityEngine;

[System.Serializable]
public class Pessoa 
{
	public string nome;
	public int saude;
	public int idade;
	public Pessoa rival;
	private int _experiencia;
	
	public Pessoa (string nome, int idade, Pessoa rival)
	{
		this.nome = nome;
		this.idade = idade;
		this.rival = rival;
		_experiencia = 0;
		saude = 100;
	}
	
	public void Respirar ()
	{
		Debug.Log(nome + " estah respirando.");
	} 	
	
	public void Envelhecer ()
	{
		_experiencia++;
	}
	
	public void AtacarSeuRival (int ataque)
	{
		if (ataque > 0)
		{
			rival.saude -= ataque;
		}
	}
	
	public int Experiencia 
	{
		get 
		{
			return _experiencia;
		}
	}
}

public class Item
{
	public string nome;
	public float preco;
	
	public Item (
		string nome = "desconhecido", 
		float preco = 0f)
	{
		this.nome = nome;
		this.preco = preco;
	}
	
	public virtual string Descrever ()
	{
		return nome + " que custa " + preco + " feijoes";
	}
}

public class Arma : Item
{
	public float ataque;
	
	public Arma (string nome, float ataque)
		: base (nome)
	{
		this.ataque = ataque;
		base.preco = ataque * 10f;
	} 
	
	public override string Descrever () {
		return nome + " que custa " + preco + 
			" feijoes e tem a forca de " + 
			ataque + " mosquitos";
	}
}




