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
        string resultadoConversion = convertir(cantidad,moneda);
        Debug.Log(resultadoConversion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string convertir(float cantidad, string moneda)
    {
        if (moneda == "euros")
        {
            float conversionADolar = cantidad * 1.10795f;
            string conversion = cantidad + " euros equivalen a " + conversionADolar + " dolars.";
            return conversion;
        }
        else if (moneda == "dolars")
        {
            float conversionADolar = cantidad * 0.898012f;
            string conversion = cantidad + " dolars equivalen a " + conversionADolar + " euros.";
            return conversion;
        }
        else
        {
            string conversion = "Porfavor, en moneda escribre euros o dolars.";
            return conversion;
        }
    }
}
