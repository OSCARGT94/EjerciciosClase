using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vida = 13;
    float exp = 10f;
    float multiplicacion, cociente, resto, doble, triple;
    // Start is called before the first frame update
    void Start()
    {
        multiplicacion = vida * exp;
        cociente = vida / exp;
        resto = vida % exp;
        doble = 2 * vida;
        triple = 3 * exp;

        Debug.Log("resultado de multiplicar es " + multiplicacion);
        Debug.Log("resultado del cociente es " + cociente);
        Debug.Log("resultado del resto es " + resto);
        Debug.Log("resultado del doble es " + doble);
        Debug.Log("resultado del triple es " + triple);


    }

    // Update is called once per frame
    void Update()
    {

    }
}