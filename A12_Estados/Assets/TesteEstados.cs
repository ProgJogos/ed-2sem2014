using UnityEngine;
using System.Collections;

public class TesteEstados : MonoBehaviour
{
	public IEstado estadoAtual;

	void Start()
	{
		estadoAtual = new Parado();
	}
	
	void Update()
	{
		estadoAtual.Update();
		estadoAtual = estadoAtual.TratarInputs();
	}
}
