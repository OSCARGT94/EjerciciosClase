using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float basee,altura;
    float areaTriangulo;
    // Start is called before the first frame update
    void Start()
    {
        areaTriangulo = (basee * altura) / 2;
        Debug.Log("El area de tu cono de vision es " + areaTriangulo );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
