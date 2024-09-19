using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Como se define mi personaje.
    // Propiedades o atributos.
    private string nombre;
    private float vida;
    private float danho;
    private float velocidad;

    public float Vida { get => vida; set => vida = value; }

    // Que puede hacer mi personaje.
    // Funcionalidades.
    public void mover(float x, float y, float z)
    {

    }

    void atacar()
    {

    }

    void saltar()
    {

    }
}
