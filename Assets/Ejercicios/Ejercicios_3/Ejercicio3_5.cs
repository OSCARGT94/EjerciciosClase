using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio, longitudCircunferencia, areaCircunferencia;
    float pi = 3.14f;
    // Start is called before the first frame update
    void Start()
    {
        //Longitud de la circunferencia =  2*PI*Radio, Área de la circunferencia = PI*Radio^2
        longitudCircunferencia = 2 * pi * radio;
        areaCircunferencia = pi * (radio * radio);
        Debug.Log("longitud de la circufenrecia es " + longitudCircunferencia);
        Debug.Log("Area de la circufenrecia es " + areaCircunferencia);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
