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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float areacirculo(float radio, float pi)
    {
        float resultadoArea = (radio * 2) * pi;
        return resultadoArea;
    }
}
