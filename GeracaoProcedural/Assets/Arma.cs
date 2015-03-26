using UnityEngine;
using System.Collections;

[System.Serializable]
public class Arma 
{
	public string nome;
	public float dano;
	public float frequencia;
	public int municao;
	
	public Arma (int pontos)
	{
		bool pronta = false;
		while (!pronta) {
			// colocar valores minimo (nota 1)
			dano = 0.1f;
			municao = 1;
			frequencia = 5;
			int distribuir = pontos;
			dano = Mathf.Clamp01(dano + Random.Range (0f, 0.9f));
			distribuir -= notaDano();
			frequencia -= Random.Range(0f, 4.9f);
			distribuir -= notaFrequencia();
			municao += Random.Range(0, 19);
			distribuir -= notaMunicao();
			if(distribuir == 1) {
				pronta = true;
			}
		}

	}
	
	int notaDano() {
		return Mathf.CeilToInt (dano * 5f);
	}
	
	int notaFrequencia() {
		return Mathf.CeilToInt (5f - frequencia);
	}
	
	int notaMunicao() {
		return Mathf.CeilToInt ((float)municao / 4f);
	}
}
