using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    int resultadoPar;
    // Start is called before the first frame update
    void Start()
    {
        while (numero1 <= numero2)
        {
            resultadoPar = numero1 % 2;
            if (resultadoPar == 0)
            {
                Debug.Log(numero1);
            }
            else
            {
                Debug.Log("");
            }
            numero1++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
