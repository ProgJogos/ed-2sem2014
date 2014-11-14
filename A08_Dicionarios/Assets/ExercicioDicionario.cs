using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ExercicioDicionario : MonoBehaviour
{
    Dictionary<string, Color> cores;
    
    void Start()
    {
        cores = new Dictionary<string, Color>();
        cores.Add("aberto", Color.green);
    }
}
