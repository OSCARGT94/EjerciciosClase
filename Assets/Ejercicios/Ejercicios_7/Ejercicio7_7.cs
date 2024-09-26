using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < numero2)
        {
            while (numero1 <= numero2)
            {
                Debug.Log(numero1);
                numero1++;
            }
        }
        else if (numero2 < numero1)
        {
            while (numero2 <= numero1)
            {
                Debug.Log(numero2);
                numero2++;
            }
        }
        else
        {
            Debug.Log("Los numeros no pueden ser iguales.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
