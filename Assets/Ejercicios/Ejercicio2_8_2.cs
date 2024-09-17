using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Ejercicio2_8_2 : MonoBehaviour
{
    float vidaInicial = 120;
    float vidaActual = 120;
    float restaDeVida;
    float porcentajeVeneno;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("la vida inicial de pepe es 120.");
    }

    // Update is called once per frame
    void Update()
    {

        for (int turno = 1 ; turno <= 5; turno++)
        {
            porcentajeVeneno = 3 * turno;
            restaDeVida = vidaInicial * porcentajeVeneno / 100;
            vidaActual -= restaDeVida;
            Debug.Log("Estamos en el turno " + turno);
            Debug.Log("Pepe pierde un " + porcentajeVeneno + "% salud por el veneno, su vida ahora es..." + vidaActual);
            Debug.Log("Ha perdido " + restaDeVida + " puntos de salud.");
        }
    }
}
