using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int numero;
        int comprobacionPar;
    // Start is called before the first frame update
    void Start()
    {
        comprobacionPar = numero;
        comprobacionPar %= 2;
        if (comprobacionPar == 0)
        {
            Debug.Log( numero + " es par.");
        }
        else
        {
            Debug.Log(numero + " es impar.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
