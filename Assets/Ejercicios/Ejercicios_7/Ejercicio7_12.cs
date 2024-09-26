using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int numeroDado1, numeroDado2;
    int resultado;
    // Start is called before the first frame update
    void Start()
    {
        int resultadoTotal = SumarTodosLosNumeros(numeroDado1, numeroDado2);
        Debug.Log(" El resultadod e sumar " +numeroDado1 + " y " + numeroDado2 + " mas todos sus numeros comprendidos entre estos dos es " + resultadoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int SumarTodosLosNumeros(int numero1, int numero2)
    {
        
        for (int i = numero1; i <= numero2; i++)
        {
           resultado += i;

        }

        return resultado;
    }
}
