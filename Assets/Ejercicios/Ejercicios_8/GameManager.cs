using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool yaEjecutado = false;
    [SerializeField] Personaje personaje1, enemigo;
    // Start is called before the first frame update
    void Start()
    {
        yaEjecutado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (yaEjecutado == false && Input.GetKeyDown(KeyCode.Space))
        {
            prepararPersonajes();
            personaje1.CalcularNivel(0);
        }


    }
    void prepararPersonajes()
    {
        personaje1.Nombre = "Pepe";
        enemigo.Nombre = "Paco";
        personaje1.Vida = 100;
        enemigo.Vida = 100;

        yaEjecutado = true;

        Debug.Log("Nombre " + personaje1.Nombre + " vida " + personaje1.Vida);
        Debug.Log("Nombre " + enemigo.Nombre + " vida " + enemigo.Vida);
    }
    public void FinDeTurno()
    {
        //Me he atascado en el 8.5, no se como hacer lo de la boleana.
    }
}