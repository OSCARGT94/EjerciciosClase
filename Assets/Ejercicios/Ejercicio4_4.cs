using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float kmH;
    float mS, division = 3.6f;
    // Start is called before the first frame update
    void Start()
    {
        string resultadoConversion = conversion(kmH, division);
        Debug.Log(resultadoConversion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string conversion(float kmH, float division)
    {
        mS = kmH / division;
        string resultado ="Tu coche va a " + mS + " metros por segundo, ¡¡que rapido!!";
        return resultado;
    }
}
