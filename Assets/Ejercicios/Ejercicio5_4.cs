using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float numero1, Divisor;    
    // Start is called before the first frame update
    void Start()
    {
        if (Divisor == 0)
        {
            Debug.Log("El divisor no puede ser 0, prueba otro numero.");
        }
        else
        {
            numero1 /= Divisor;
            Debug.Log("El resultado es " + numero1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
