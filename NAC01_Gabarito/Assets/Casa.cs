using UnityEngine;
using System.Collections;

public class Casa : MonoBehaviour
{

    public int jogador;

    void Start()
    {
        jogador = 0;
    }
	
    void OnMouseDown()
    {
        if (jogador == 0)
        {
            Clique novo = new Clique(Arbitro.jogadorDaVez, this);
            novo.Executar(true);
        }
    }
}
