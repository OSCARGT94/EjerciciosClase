using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vida = 13;
    float exp = 10f;
    char guerrero = 'g';
    float resultadoSumas, resultadoRestas;
    //[SerializeField] int casas = 2;
    // Start is called before the first frame update
    void Start()
    {
        resultadoSumas = vida + exp;
        resultadoSumas = vida - exp;
        Debug.Log(resultadoSumas);
        Debug.Log(resultadoRestas);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
