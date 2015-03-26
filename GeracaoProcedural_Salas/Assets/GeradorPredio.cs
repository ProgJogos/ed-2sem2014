using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GeradorPredio : MonoBehaviour {
	public Sala[] prefabsSala;
	public int nroSalas = 1;
	public List<Sala> salas;

	void Start () {
		salas = new List<Sala>();
		int i = 0;
		while(salas.Count < nroSalas) {
			// primeira sala
			if (i == 0) {
				salas.Add(Instantiate(
							prefabsSala[Random.Range (0, prefabsSala.Length)],
				            Vector3.zero,
				            Quaternion.identity) as Sala);
				foreach(var porta in salas[0].portas){
					porta.Inicializar();
				}
				salas[salas.Count-1].name = "S_" + (salas.Count-1);
			}
			else {
				foreach(var porta in salas[i-1].portas){
					if(salas.Count == nroSalas) {
						break;
					}
					// a porta esta vazia?
					if(porta.proxSala == null) {
						// criei uma sala no 0, 0, 0
						salas.Add(Instantiate(
							prefabsSala[Random.Range (0, prefabsSala.Length)],
  	                        Vector3.zero,
	    	                Quaternion.identity) as Sala);
						foreach(var portaNova in salas[i].portas){
							portaNova.Inicializar();
						}
						salas[salas.Count-1].name = "S_" + (salas.Count-1);
						// conectei a porta atual com uma porta
						// aleatoria da nova sala
						int indNovaPorta = Random.Range(0, salas[i].portas.Length);
						porta.proxSala = salas[i];
						salas[i].portas[indNovaPorta].proxSala = salas[i-1];
						// calcular a rotacao da nova sala
						Vector3 direcaoPortaNovaSala = porta.transform.forward;
						// mover a Sala para sua posicao correta
						Vector3 posNova = porta.transform.position +
							salas[i].portas[indNovaPorta].offsetSala;
						salas[i].transform.position = posNova;
						salas[i].transform.RotateAround(
							salas[i].portas[indNovaPorta].transform.position,
							Vector3.up,
							Vector3.Angle(
								salas[i].portas[indNovaPorta].transform.forward,
						        -direcaoPortaNovaSala));
					}
				}
			}
			i++;
		}
	}
}

