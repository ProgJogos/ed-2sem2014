using UnityEngine;
using System.Collections;

public class TesteEstados : MonoBehaviour
{
	public IEstado estadoAtual;
	public IEstado estadoNovo;

	void Start()
	{
		estadoAtual = new Parado();
	}
	
	void Update()
	{
		estadoAtual.Update();
		estadoNovo = estadoAtual.TratarInputs();
		if (estadoNovo != estadoAtual)
		{
			estadoAtual.Sair();
			estadoAtual = estadoNovo;
			estadoAtual.Entrar();
		}
	}
}
