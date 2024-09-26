using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    string nombre = "oscar";
    int frame;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola mundo!");
        Debug.Log( "Este es el primer videojuego de " + nombre );
        Debug.Log("Estoy aprendiendo C# ");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado " + frame + " frame/s");
        frame++;
        //Este mensaje se repite constatemente al pasar cada frame, pudiendo variar dependiendo de la velocidad del ordenador.
    }
}
