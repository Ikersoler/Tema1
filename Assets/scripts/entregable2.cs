using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entregable2 : MonoBehaviour
{

    [SerializeField] private int num1;
    [SerializeField] private int num2;
    [SerializeField] private int result;
    [SerializeField] private string name = "iker";
    [SerializeField] private int intNumbre1;
    [SerializeField] private int intNumbre2;

    // Start is called before the first frame update
    private void Start()
    {

        //primer ejercicio-------------------------------------
        Debug.Log(message: $"{num1} + {num2} = {num1 + num2}");
        //el resultado es 4 + 2 = 6


        //segundo ejercicio------------------------------------
        if (num1 >= num2)
        {
            Debug.Log(message: $"{num1} es mayor que {num2}");

        }
        else
        {
            Debug.Log(message: $"{num1} es menor que {num2}");

        }
        // el resultado es 4 es mayor que 2

        //tercer ejercicio-------------------------------------
        result = num1 + num2;
        Debug.Log(message: $"result = {result}");
        //el resultado es(result = 6)


        //cuarto ejercicio
        Debug.Log(message: $"hola como estas {name}");
        //el resultado es hola como estas iker 


        //quinto ejercicio------------------------------------
        if (intNumbre1 % 2 == 1)
        {
            Debug.Log(message:$"{intNumbre1} es impar ");
        }
        else
        {
            Debug.Log(message: $"{intNumbre1} es par ");

        }

        if (intNumbre2 % 2 == 1)
        {
            Debug.Log(message: $"{intNumbre2} es impar ");
        }
        else
        {
            Debug.Log(message: $"{intNumbre2} es par ");

        }
        //los resultasos son 1 es impar y dos 2 es par


    }

   
}
