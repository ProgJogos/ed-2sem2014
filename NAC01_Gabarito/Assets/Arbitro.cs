using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Arbitro : MonoBehaviour
{
    public static int jogadorDaVez;
    public static List<Clique> historico;

    void Start()
    {
        jogadorDaVez = 1;
        historico = new List<Clique>();
    }
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && historico.Count > 0)
        {
            StartCoroutine("TocarReplay");
        }
    }
    
    IEnumerator TocarReplay()
    {
        // zerei minhas casas
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Casa"))
        {
            go.renderer.material.color = Color.white;
            go.GetComponent<Casa>().jogador = 0;
        }
        
        foreach (Clique comando in historico)
        {
            yield return new WaitForSeconds(0.5f);
            comando.Executar(false);
        }
    }

}
