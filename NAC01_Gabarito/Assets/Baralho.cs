using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
// importar biblioteca para List

[System.Serializable]
public class Baralho
{
    public List<Carta> cartas;

    public Baralho()
    {
        cartas = new List<Carta>();

        for (int valor = 1; valor <= 13; valor++)
        {
            cartas.Add(new Carta(valor, "paus"));
        }

        for (int valor = 1; valor <= 13; valor++)
        {
            cartas.Add(new Carta(valor, "copas"));
        }

        for (int valor = 1; valor <= 13; valor++)
        {
            cartas.Add(new Carta(valor, "espada"));
        }

        for (int valor = 1; valor <= 13; valor++)
        {
            cartas.Add(new Carta(valor, "ouros"));
        }

        Debug.Log(cartas.Count);
    }

    public void Embaralhar()
    {
        for (int c = 0; c < 1000; c++)
        {
            int i1 = Random.Range(0, cartas.Count);
            int i2 = Random.Range(0, cartas.Count);
            Carta temp = cartas [i2];
            cartas [i2] = cartas [i1];
            cartas [i1] = temp;
        }
    }

    public Carta ComprarCarta()
    {
        Carta resultado;
        if (cartas.Count > 0)
        {
            resultado = cartas [cartas.Count - 1];
            cartas.RemoveAt(cartas.Count - 1);
            return resultado;
        }
        return null;
    }

    public void Descarte(Carta nova)
    {
        cartas.Add(nova);
    }
}
