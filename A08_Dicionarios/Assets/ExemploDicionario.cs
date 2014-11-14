using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ExemploDicionario : MonoBehaviour
{
    // declaracao de um dicionario
    public Dictionary<string, Vector3> posicoes;
     
    void Start()
    {
        posicoes = new Dictionary<string, Vector3>();
        
        // posicoes.Add("bob", new Vector3(1, 1, 1));
        if (posicoes.ContainsKey("bob"))
        {
            print("bob jah existe");
        } else
        {
            posicoes.Add("bob", new Vector3(3, 39, 3));
            posicoes.Add("jao", new Vector3(4, 4, 4));
            // print(posicoes ["bobi"]);
        }
        
        print(posicoes.Count); // 1
        
        float res = 0;
        print("div: " + Dividir(10, 3, out res)); // true
        
        Vector3 valor = Vector3.zero;
        print(posicoes.TryGetValue("bob", out valor));
        print(valor);
        
        print(posicoes.Remove("ana"));
        // print(posicoes.Remove("bob"));
        
        foreach (var posicao in posicoes)
        {
            print(posicao.Key + " " + posicao.Value);
        }
        
    }
    
    bool Dividir(float a, float b, out float resultado)
    {
        if (b == 0)
        {
            resultado = 0;
            return false;
        }
        
        resultado = a / b;
        return true;
    }
}








