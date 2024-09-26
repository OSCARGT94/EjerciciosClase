using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 12, vidasPlayer2 = 11, vidasPlayer3 = 13, vidasPlayer4 = 14;
    int vidasPlayer1Original = 12, vidasPlayer2Original = 11, vidasPlayer3Original = 13, vidasPlayer4Original = 14;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("los valores originales son vidasPlayer1 = " + vidasPlayer1);
        Debug.Log("los valores originales son vidasPlayer2 = " + vidasPlayer2);
        Debug.Log("los valores originales son vidasPlayer3 = " + vidasPlayer3);
        Debug.Log("los valores originales son vidasPlayer4 = " + vidasPlayer4);
        vidasPlayer2 = vidasPlayer3Original;
        Debug.Log("vidasPlayer2 toma el valor inicial de vidasPlayer3 y se queda en " + vidasPlayer2);
        vidasPlayer3 = vidasPlayer1Original;
        Debug.Log("vidasPlayer3 toma el valor inicial de vidasPlayer1 y se queda en " + vidasPlayer3);
        vidasPlayer1 = vidasPlayer4Original;
        Debug.Log("vidasPlayer1 toma el valor inicial de vidasPlayer4 y se queda en " + vidasPlayer1);
        vidasPlayer4 = vidasPlayer2Original;
        Debug.Log("vidasPlayer4 toma el valor inicial de vidasPlayer2 y se queda en " + vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
