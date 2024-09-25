using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    int numeroInicial = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (numeroInicial <= numero1)
        {
            Debug.Log(numeroInicial);
            numeroInicial++;
        }

        for (int numeros = numeroInicial; numeros <= numero2; numeros++)
        {
            Debug.Log(numeros);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
