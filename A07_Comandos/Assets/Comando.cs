using UnityEngine;
using System.Collections.Generic;

// superclasse abstrata
public abstract class Comando
{
	public abstract void Executar (bool gravar);
	public abstract void Desfazer ();
}

public enum Direcao {
	NORTE,
	LESTE,
	SUL,
	OESTE
}

// subclasse Mover
public class Mover : Comando
{
	public Direcao destino;
	public Transform objeto;
	public List<Comando> historico;
	public Vector3 _posAnterior;

	public Mover (Transform obj, Direcao destino, ref List<Comando> lista)
	{
		this.objeto = obj;
		this.destino = destino;
		this.historico = lista;
		this._posAnterior = objeto.position;
	}

	public override void Executar (bool gravar)
	{
		switch (destino) 
		{
		case Direcao.NORTE :
			objeto.Translate(0, 2f, 0);
			break;
		case Direcao.LESTE :
			objeto.Translate(2f, 0, 0);
			break;
		case Direcao.SUL :
			objeto.Translate(0, -2f, 0);
			break;
		case Direcao.OESTE :
			objeto.Translate(-2f, 0, 0);
			break;
		}
		if(gravar) historico.Add(this);
	}

	public override void Desfazer ()
	{
		objeto.position = _posAnterior;
		historico.Remove (this);
	}
}







