using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField]float kmH;
    float mS, division = 3.6f;
    // Start is called before the first frame update
    void Start()
    {
        mS = kmH / division;
        Debug.Log("Tu coche va a " + mS + " metros por segundo, ¡¡que rapido!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
