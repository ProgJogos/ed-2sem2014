using UnityEngine;

public class Animal
{
	// atributos
	public string nome;
	public float peso;
	
	// funçao construtora
	public Animal (string pNome, float pPeso)
	{
		Debug.Log ("entrou construtor animal");
		this.nome = pNome;
		this.peso = pPeso;
	}
	
	// metodo publico
	public void Descrever ()
	{
		Debug.Log (nome + " pesa " + peso + " kgs.");
	}
}

public class Gato : Animal
{
	public int vidas;
	
	// ex. new Gato ("garfield", 20f, 9)
	public Gato (string nome, float peso, int vidas) 
		: base (nome, peso)
	{
		Debug.Log ("entrou construtor gato");
		this.vidas = vidas;
	}
	 
	public void Miar ()
	{
		Debug.Log (nome + " miou!");
	}
}

public class PeixeBoi : Animal
{
	// construtor
	public PeixeBoi (string nome)
		: base (nome, 400f) {}
		
	// metodos publicos
	public void Nadar ()
	{
		Debug.Log(nome + " esta nadando.");
	}
	
	public void Ruminar ()
	{
		Debug.Log(nome + " esta ruminando.");
		this.peso += 10f;
	}
	
	public void Descrever ()
	{
		Debug.Log(nome + " pesa " + peso + 
			" kgs e mora no rio.");
	}
}






