using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    [SerializeField]string moneda = "euros";
    [SerializeField]float cantidad = 20;
    // Start is called before the first frame update
    void Start()
    {
        convertir(cantidad,moneda);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void convertir(float cantidad, string moneda)
    {
        if (moneda == "euros")
        {
            float conversionADolar = cantidad * 1.10795f;
        }
        else if (moneda == "dolars")
        {

        }
        else
        {

        }
    }
}
