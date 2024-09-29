using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] GameObject enemigo;
    [SerializeField] Arma arma;
    [SerializeField] SistemaDeVida sistemaDeVida;
    [SerializeField] KeyCode cura;
    [SerializeField] KeyCode ataque;
    [SerializeField] KeyCode recarga;
    public bool miTurno;
    // Como se define mi personaje.
    // Propiedades o atributos.
    private string nombre;
    private int vida;
    private float experiencia;
    float calcularLvl;
    public int Vida { get => vida; set => vida = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public bool MiTurno { get => miTurno; set => miTurno = value; }

    // Que puede hacer mi personaje.
    // Funcionalidades.
    void Start()
    {
        //calcularLvl = CalcularNivel(experiencia);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(cura))
        {
            sistemaDeVida.RecibirCura(sistemaDeVida.CuraIntroducidad);
        }
        if (Input.GetKeyDown(ataque))
        {
            arma.UtilizarArma();
        }
        if (Input.GetKeyDown(recarga))
        {
            arma.RecargarArma();
        }

    }

    public float CalcularNivel(float exp)
    {
        float LVL = exp / 1000;
        Debug.Log(" El nivel es " + LVL);
        return LVL;
    }
}
