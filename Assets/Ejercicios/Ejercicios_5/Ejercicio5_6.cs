using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int niveles;
    int comprovacionNivel;
    // Start is called before the first frame update
    void Start()
    {
        comprovacionNivel = niveles;
        comprovacionNivel %= 10;

        if (comprovacionNivel == 0)
        {
            Debug.Log("Es multiplo, aprendio un ataque nuevo.");
        }
        else
        {
            Debug.Log("No es multiplo, prueba otro nivel.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
