using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    // Como se define mi personaje.
    // Propiedades o atributos.
    private string nombre;
    private float vida;
    private float experiencia;

    public float Vida { get => vida; set => vida = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    // Que puede hacer mi personaje.
    // Funcionalidades.
    void Start()
    {
        float calcularLvl = CalcularNivel(experiencia);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void mover(float x, float y, float z)
    {

    }

    float CalcularNivel(float exp)
    {
        float LVL = exp / 1000;
        return LVL;
    }
}
