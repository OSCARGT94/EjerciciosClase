using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 3, puntuacion2 = 6, puntuacion3 = 9, resultadoSumas, media;
    int numeroDePuntuaciones = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Oscar tiene 3 puntuaciones puntuacion1 = " +puntuacion1 + ", puntuacion2 = " + puntuacion2 + " y puntuacion3 = " +puntuacion3);
        resultadoSumas = puntuacion1 + puntuacion2 + puntuacion3;
        Debug.Log("la suma de esos valores es la siguiente," + puntuacion1 + " + " + puntuacion2 + " + " + puntuacion3 + " = " + resultadoSumas);
        media = resultadoSumas /= numeroDePuntuaciones;
        Debug.Log("Por tanto si divido eso entre 3, la media es " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
