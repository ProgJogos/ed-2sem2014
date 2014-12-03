using UnityEngine;
using System.Collections;

public class Clique
{
    public int jogador;
    public Casa casa;
	
    public Clique(int j, Casa c)
    {
        this.jogador = j;
        this.casa = c;
    }

    public void Executar(bool gravar)
    {
        casa.jogador = jogador;
        
        if (jogador == 1)
        {
            casa.renderer.material.color = Color.red;
        } else
        {
            casa.renderer.material.color = Color.yellow;
        }
        
        if (Arbitro.jogadorDaVez == 1)
        {
            Arbitro.jogadorDaVez = 2;
        } else
        {
            Arbitro.jogadorDaVez = 1;
        }
        
        if (gravar)
            Arbitro.historico.Add(this);
        
    }                      
}
