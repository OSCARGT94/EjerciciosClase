using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numeros;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Escribe un numero comprendido entre 0 y 9");

        if (numeros >= 0 && numeros <= 9)
        {
            Debug.Log("Bien " + numeros + " es un numero comprendido entre 0 y 9.");
        }
        else
        {
            Debug.Log( numeros + " no es un numero comprendido entre 0 y 9, sigue intentandolo.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
