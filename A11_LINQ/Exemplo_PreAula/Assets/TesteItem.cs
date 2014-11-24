using UnityEngine;
using System.Collections.Generic;
using System.Linq; // importacao da biblioteca para uso de linq

public class TesteItem : MonoBehaviour
{
    public List<Item> inventario;
    
    void Start ()
    {
        // inicializacao de uma lista de itens
        inventario = new List<Item> {
            new Item("punhal", 100, 5f),
            new Item("roupa de couro", 300, 10f),
            new Item("banana", 1, 0.5f),
            new Item("carne de sol", 10, 1f),
            new Item("caxixi", 20, 0.2f),
            new Item("pifano", 30, 0.1f),
            new Item("livros de cordel", 40, 1f)
        };
        
        // SINTAXE DE CONSULTA
        // guarda o resultado da consulta em um conjunto "baratos"
        //var baratos = from item in inventario // de cada item do inventario
        //    where item.preco <= 20            // quando seu preco for menor que 20
        //    select item.nome;                 // retorne apenas seu nome
       
        // SINTAXE DE METODO
        var baratos = inventario.Where (item => item.preco <= 20).Select (item => item.nome);
            
        // usa o conjunto assim criado para exibir seus nomes   
        foreach (var nome in baratos) {
            print (nome);
        }
    }
}

