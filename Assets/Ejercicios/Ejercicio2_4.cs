using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 12;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("vida inicial = " + vidas);
        vidas += 77;
        Debug.Log("sumamos 77 y se queda en..." + vidas);
        vidas -= 3;
        Debug.Log("restamos 3 y se queda en..." + vidas);
        vidas *= 4;
        Debug.Log("multiplicamos por 4 y se queda en..." + vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
