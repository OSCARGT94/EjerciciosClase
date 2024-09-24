using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int numeros = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (numeros < 101)
        {
            Debug.Log(numeros);
            numeros++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
