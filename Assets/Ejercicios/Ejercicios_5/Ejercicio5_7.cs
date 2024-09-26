using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] float velocidad1, velocidad2, velocidad3;
    // Start is called before the first frame update
    void Start()
    {
        if (velocidad1 > velocidad2 && velocidad1 > velocidad3)
        {
            if (velocidad2 > velocidad3)
            {
                Debug.Log("El orden de los turnos es el siguiente, primero el jugador 1, luego jugador 2 y luego jugador 3.");
            }
            else
            {
                Debug.Log("El orden de los turnos es el siguiente, primero el jugador 1, luego jugador 3 y luego jugador 2.");
            }
        }
        else if (velocidad2 > velocidad1 && velocidad2 > velocidad3)
        {
            if (velocidad1 > velocidad3)
            {
                Debug.Log("El orden de los turnos es el siguiente, primero el jugador 2, luego jugador 1 y luego jugador 3.");
            }
            else
            {
                Debug.Log("El orden de los turnos es el siguiente, primero el jugador 2, luego jugador 3 y luego jugador 1.");
            }
        }
        else
        {
            if (velocidad1 > velocidad2)
            {
                Debug.Log("El orden de los turnos es el siguiente, primero el jugador 3, luego jugador 1 y luego jugador 2.");
            }
            else
            {
                Debug.Log("El orden de los turnos es el siguiente, primero el jugador 3, luego jugador 2 y luego jugador 1.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
