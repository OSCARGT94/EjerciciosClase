using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int numeroDado;
    int resultado;
    int conteo = 0;
    bool primoComrpobador = false;
    // Start is called before the first frame update
    void Start()
    {
        bool resultadoFinal = primo(numeroDado);
        if (resultadoFinal == true)
        {
            Debug.Log("El numero " + numeroDado + " no es primo.");
        }
        else
        {
            Debug.Log("El numero " + numeroDado + " es primo.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool primo(int numero1)
    {
        for (int i = 1; i <= numero1; i++)
        {
            numero1 %= i;
            if (numero1 == 0)
            {                
                conteo++;
            }
            numero1 = numeroDado;
            
        }

        if (conteo >= 3)
        {
            primoComrpobador = true;
        }

        return primoComrpobador;
               
    }
}
