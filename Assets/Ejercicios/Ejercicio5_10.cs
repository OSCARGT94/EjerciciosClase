using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] float TP;
    // Start is called before the first frame update
    void Start()
    {
        if (TP <= 10)
        {
            Debug.Log("Frio.");
        }
        else if (10 < TP && TP <= 20)
        {
            Debug.Log("Nublado.");
        }
        else if (20 < TP && TP <= 30)
        {
            Debug.Log("Caluroso.");
        } 
        else if ( TP > 30)
        {
            Debug.Log("Tropical.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
