using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class ExemploArquivoTexto : MonoBehaviour {

	public int contador;
	
	void Start () {
		if (!File.Exists (Application.dataPath + "\\contador.txt")) {
			var arq = File.CreateText(Application.dataPath + "\\contador.txt");
			arq.Write("0");
			arq.Close();
		}
		string conteudo = File.ReadAllText (
			Application.dataPath + "\\contador.txt");
		Debug.Log (conteudo);
		contador = Int32.Parse (conteudo);
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			contador++;
			File.WriteAllText(Application.dataPath + "\\contador.txt",
			                  contador.ToString());
		}
		
		if (Input.GetKeyDown (KeyCode.R)) {
			contador = 0;
			File.WriteAllText(Application.dataPath + "\\contador.txt",
			                  contador.ToString());
		}
	}
}
