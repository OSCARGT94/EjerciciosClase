using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultadoAreacirculo = areacirculo(3, 3.14f);
        Debug.Log("El resultado del area del circulo es " + resultadoAreacirculo);

        float resultadoAreaTriangulo = areatriangulo(3, 3);
        Debug.Log("El resultado del area del circulo es " + resultadoAreaTriangulo);

        float resultadoAreaCuadrado = areacuadrado(4);
        Debug.Log("El resultado del area del circulo es " + resultadoAreaCuadrado);



        string resultadoConversionCirculo = convertir(resultadoAreacirculo);
        Debug.Log("Dado del area del circulo " + resultadoConversionCirculo);

        string resultadoConversionTriangulo = convertir(resultadoAreaTriangulo);
        Debug.Log("Dado del area del triangulo " + resultadoConversionTriangulo);

        string resultadoConversionCuadrado = convertir(resultadoAreaCuadrado);
        Debug.Log("Dado del area del cuadrado " + resultadoConversionCuadrado);
    }

    // Update is called once per frame
    void Update()
    {

    }
    float areacirculo(float radio, float pi)
    {
        float resultadoArea = (radio * radio) * pi;
        return resultadoArea;
    }
    float areatriangulo(float basee, float altura)
    {
        float resultadoArea = (basee * altura) / 2;
        return resultadoArea;
    }
    float areacuadrado(float lado)
    {
        float resultadoArea = lado * lado;
        return resultadoArea;
    }



    string convertir(float cantidad)
    {

        float conversionADolar = cantidad * 1.10795f;
        string conversion = cantidad + " euros equivalen a " + conversionADolar + " dolars.";
        return conversion;

    }
}
