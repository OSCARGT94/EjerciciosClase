using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    int resultadoPar;
    // Start is called before the first frame update
    void Start()
    {
        while (numero1 <= numero2)
        {
            resultadoPar = numero1 % 2;
            if (resultadoPar == 0)
            {
                Debug.Log("El numero " + numero1+ " es par."); ;
            }
            else
            {
                Debug.Log("El numero " + numero1+ "  es impar.");
            }

            if(numero1 < 0)
            {
                Debug.Log("El nunmero " + numero1+ "  es negativo.");
            }
            else
            {
                Debug.Log("El nunmero " + numero1+ "  es positivo.");
            }
            numero1++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
