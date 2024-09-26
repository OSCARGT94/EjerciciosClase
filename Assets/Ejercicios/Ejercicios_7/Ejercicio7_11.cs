using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField]int numero1;
    int resultado;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {            
            resultado = numero1 * i;
            Debug.Log( numero1 + " x " + i + "=" + resultado);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
