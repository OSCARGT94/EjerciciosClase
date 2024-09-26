using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] float vidaPaco, vidaPepe;
    // Start is called before the first frame update
    void Start()
    {
        if (vidaPaco == vidaPepe)
        {
            Debug.Log("¡Vaya Pepe y Paco estan empatados!");
        }
        else if (vidaPepe < vidaPaco) 
        {
            Debug.Log("¡Vaya Paco va ganando!");
        }
        else
        {
            Debug.Log("¡Vaya Pepe va ganando!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
