using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1,numero2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Intententa que ambos numeros sean menores que 3");
        if (numero1 < 3 && numero2 < 3)
        {
            Debug.Log("¡¡Son menores que 3 ambos wiii!!");
        }
        else
        {
            Debug.Log("Sigue intentandolo.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
