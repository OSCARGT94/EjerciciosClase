using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    // Start is called before the first frame update
    void Start()
    {
        if (tipo < 1 || tipo > 6)
        {
            Debug.Log("Inserte un tipo del 1 al 6 inclusive.");

        }

        if (tipo == 1)
        {
            Debug.Log("Daño 350, vida 650.");
        }
        else if (tipo == 2)
        {
            Debug.Log("Daño 300, vida 550.");
        }
        else if (tipo == 3)
        {
            Debug.Log("Daño 300, vida 500.");
        }
        else if (tipo == 4)
        {
            Debug.Log("Daño 310, vida 460.");
        }
        else if (tipo == 5)
        {
            Debug.Log("Daño 280, vida 490.");
        }
        else if (tipo == 6)
        {
            Debug.Log("Daño 360, vida 520.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
