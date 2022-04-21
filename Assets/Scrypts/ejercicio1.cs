using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Realizar un rpograma que muestre los numeros de forma descendente entre dos grupos enteros ingresados por el usuario, incluyendolos. 
// Chequear que no sean iguales y que el primero sea mayor que el segundo.



public class ejercicio1 : MonoBehaviour
{
    public int n1;
    public int n2;
    // Start is called before the first frame update
    void Start()
    {
        if (n1 == n2)
        {
            Debug.Log("Los numeros no pueen ser iguales");
        }

        else if (n1 < n2)
        {
            Debug.Log("El segundo numero no puede ser menor que el primero");
        }
        else
        {
            while (n1 >= n2)
          {
           Debug.Log(n1);
           n1--;
          }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
