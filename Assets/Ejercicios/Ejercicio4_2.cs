using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    [SerializeField]string nombre, apellido, apellido2;
    [SerializeField]int edad;
    // Start is called before the first frame update
    void Start()
    {
       string resultadoInforacion = construirNombre(nombre, apellido, apellido2, edad);
       
        Debug.Log(resultadoInforacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string construirNombre(string nombre, string apellido, string apellido2, int edad)
    {
        string informacion ="La persona se llama " + nombre + " " + apellido + " " + apellido2 + " y tiene " + edad + " años.";

        return informacion;


    }
}
