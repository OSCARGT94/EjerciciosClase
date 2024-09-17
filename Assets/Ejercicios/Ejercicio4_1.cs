using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float resultadoAreaCirculo;
    // Start is called before the first frame update
    void Start()
    {
        float resultadoAreacirculo = areacirculo(3,3.14f);
        Debug.Log("El resultado del area del circulo es " + resultadoAreacirculo);
        
        float resultadoAreaTriangulo = areatriangulo(3,3);
        Debug.Log("El resultado del area del circulo es " + resultadoAreaTriangulo);
        
        float resultadoAreaCuadrado = areacuadrado(4);
        Debug.Log("El resultado del area del circulo es " + resultadoAreaCuadrado);
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
}
