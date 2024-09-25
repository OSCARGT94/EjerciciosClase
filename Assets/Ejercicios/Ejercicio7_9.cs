using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int numero1;
    int timer = 0;
    int resultadoMultiplo;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= numero1; i++)
        {
            resultadoMultiplo = 3 * i;
            Debug.Log(resultadoMultiplo);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
