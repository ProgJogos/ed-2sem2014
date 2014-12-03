using UnityEngine;
using System.Collections;

public class TesteBaralho : MonoBehaviour
{

    public Baralho meuBaralho;

    // Use this for initialization
    void Start()
    {
        meuBaralho = new Baralho();
        meuBaralho.Embaralhar();
    }
}
