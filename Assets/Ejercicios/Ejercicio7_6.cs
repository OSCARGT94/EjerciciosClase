using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero1;
    int numero2, numero3;
    // Start is called before the first frame update
    void Start()
    {
        numero2 = numero1 - (numero1 * 2);
        numero3 = numero1;

        while (numero1 >= numero2)
        {
            Debug.Log(numero1);
            numero1--;
        }
        numero1 = numero3;
        for (int numero = numero1; numero >= numero2; numero--)
        {
            Debug.Log(numero);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
