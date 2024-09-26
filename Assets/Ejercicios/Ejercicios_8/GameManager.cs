using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool yaEjecutado = false;
    [SerializeField] Personaje personaje1, personaje2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ( yaEjecutado == false && Input.GetKeyDown(KeyCode.Space))
        {
            prepararPersonajes();
        }
    }
    void prepararPersonajes()
    {
        personaje1.Nombre = "Pepe";
        personaje2.Nombre = "Paco";
        personaje1.Vida = 100;
        personaje2.Vida = 100;

        yaEjecutado = true;
    }
}
