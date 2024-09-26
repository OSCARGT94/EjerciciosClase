using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oro = 7;
    int oro1Minuto = 0, oro1Hora = 0, oro4Horas = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Pepe farmea 7 unidades de oro por segundo, es un maquina Pepe, ¿cuantas unidades de oro farmea en 4h?");        
        oro1Minuto = oro * 60;
        Debug.Log("7 unidades por 60 segundos son " + oro1Minuto + " de oro en un minuto.");
        oro1Hora = oro1Minuto * 60;
        Debug.Log(oro1Minuto + " unidades por 60 minutos son " + oro1Hora + " de oro en una hora.");
        oro4Horas = oro1Hora * 4;
        Debug.Log(oro1Hora + " unidades por 4 horas son " + oro4Horas + " de oro.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
