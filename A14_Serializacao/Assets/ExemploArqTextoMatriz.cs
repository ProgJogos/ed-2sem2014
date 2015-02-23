using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class ExemploArqTextoMatriz : MonoBehaviour {

	public TextAsset arquivo;
	public int[,] matriz = null;

	void Start () {
		string[] linhas = arquivo.text.Split(
			new string[]{"\n"}, StringSplitOptions.None);

		string[] colunas = null;
		for (int l = 0; l < linhas.Length; l++) {
			colunas =
				linhas[l].Split(new string[]{"\t"}, StringSplitOptions.None);
			for(int c = 0; c < colunas.Length; c++) {
				if(matriz == null) {
					matriz = new int[colunas.Length,linhas.Length];
				}
				matriz[c, l] = Int32.Parse(colunas[c]);
			}
		}
		string res = "";
		for (int l = 0; l < matriz.GetLength(1); l++) {
			for (int c = 0; c < matriz.GetLength(0); c++) {
				res += matriz[c, l].ToString() + " | ";
				if(c == matriz.GetLength(0)-1){
					res += "\r\n";
				}
			}
		}
		Debug.Log (res);
	}
}
