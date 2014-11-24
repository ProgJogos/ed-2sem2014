using UnityEngine;
using System.Collections;

[System.Serializable]
public class Item
{
    public string nome;
    public int preco;
    public float peso;
    
    public Item (string nome, int preco, float peso)
    {
        this.nome = nome;
        this.preco = preco;
        this.peso = peso;
    }
}
