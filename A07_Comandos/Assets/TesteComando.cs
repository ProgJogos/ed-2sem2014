using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TesteComando : MonoBehaviour {

	List<Comando> historico;
	Vector3 posOrigem;

	Comando _botaoCima;
	Comando _botaoDir;
	Comando _botaoEsq;
	Comando _botaoBaixo;

	public Transform controlado;

	void Start () {
		historico = new List<Comando> ();

		// preparando os objetos de comando
		posOrigem = controlado.position;
	}

	void Update () {
		/*
		if (Input.GetKeyDown (KeyCode.T)) {
			controlado = transform;
		}
		*/

		// tratando se um botao foi apertado
		if (Input.GetKeyDown (KeyCode.W)) {
			_botaoCima = new Mover(controlado, Direcao.NORTE, ref historico);
			_botaoCima.Executar(true);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			_botaoDir = new Mover(controlado, Direcao.LESTE, ref historico);
			_botaoDir.Executar(true);
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			_botaoBaixo = new Mover(controlado, Direcao.SUL, ref historico);
			_botaoBaixo.Executar(true);
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			_botaoEsq = new Mover(controlado, Direcao.OESTE, ref historico);
			_botaoEsq.Executar(true);
		}

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			StartCoroutine("Replay");
		}

		if (Input.GetKeyDown (KeyCode.Q) && historico.Count > 0) 
		{
			historico[historico.Count-1].Desfazer();
		}

		print ("acoes no historico: " + historico.Count);
	}

	IEnumerator Replay () {
		// vai para posicao inicial
		controlado.position = posOrigem;
		foreach (var comando in historico) {
			comando.Executar(false);
			yield return new WaitForSeconds (0.3f);
		}
	}
}
