using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numeroDado;
    int numeroPor2, numeroPor3;
    // Start is called before the first frame update
    void Start()
    {
        numeroPor2 = numeroDado * 2;
        numeroPor3 = numeroDado * 3;
        Debug.Log("El doble del numero dado es..." + numeroPor2);
        Debug.Log("El triple del numero dado es..." + numeroPor3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
