using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int h, m, s;
    // Start is called before the first frame update
    void Start()
    {
        if (h > 24  || m > 60 || s > 60)
        {
            Debug.Log("Hora no valida, porfavor pon unos valores correctos.");
        }
        else
        {
            Debug.Log("Tu hora es " + h + ":" + m + ":" + s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
