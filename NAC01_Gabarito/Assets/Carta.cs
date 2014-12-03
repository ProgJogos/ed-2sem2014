using UnityEngine;
using System.Collections;

[System.Serializable]
public class Carta
{
    public int valor;
    public string naipe;

    public Carta(int valor, string naipe)
    {
        this.valor = Mathf.Clamp(valor, 1, 13);
        this.naipe = naipe;
    }
}
