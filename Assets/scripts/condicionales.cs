using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicionales : MonoBehaviour
{

    //operadores condicionales
    //igualdad ==
    //desigualdad !=
    //menor <
    //mayor >
    //menor o igual <=
    //mayor o igual >=

    /*
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    */

    [SerializeField] private float numero;

    [SerializeField] private int lives;

    [SerializeField] private string name;
    [SerializeField] private int edad;

    [SerializeField] private float precio;
    [SerializeField] private float dinero;

    [SerializeField] private bool isOn = true;

    // Start is called before the first frame update
    private void Start()
    {




        if (precio >= dinero)
        {
            Debug.Log(message:$"{name} no tiene dinero suficiente");
        }
        else
        {
            Debug.Log(message: $"{name} tiene dinero suficiente");

        }


        if (edad >= 18)
        {
            Debug.Log(message: $"{name} es mayor de edad");
        
        }
        else
        {
            Debug.Log(message: $"{name} es menor de edad");

        }

        if (!isOn)
        {
            Debug.Log(message: "esta encendido");
        }
        else
        {
            Debug.Log(message: "esta apagado");

        }


        /*
        Debug.Log(message:num1 == num2);//igualdad

        Debug.Log(message:num2 != num1);//desigualdad

        Debug.Log(message:num1 < num2);//menor que

        Debug.Log(message: num1 > num2);//mayor que

        Debug.Log(message:num1 >= num2);//menor igual

        Debug.Log(message:num1 <= num2);//mayor igual
        */

        /*
        Debug.Log(message: numero < 0);
        Debug.Log(message: numero > 0);
        */

        /*
        if (numero > 0) 
        {
            Debug.Log(message: $"{numero}es positivo");
        
        }
        else
        {
            Debug.Log(message: $"{numero}es negativo");

        }
        */



        // if (numero < 0) 
        //{
        //  Debug.Log(message: $"{numero}es negativo");

        /*
        }

        if(lives <= 0)
        {
            Debug.Log(message: "GAME OVER");

        }
        */


        /*

        if (numero % 2 == 0)
        {
            Debug.Log(message: $"{numero} es par");

        }
        else
        {
            Debug.Log(message: $"{numero} es inpar");
        }
        */


        /*
        if (numero % 2 != 0) //tambien se puede cambiar el 0 a 1 (numero % 2 == 1)
        {
            Debug.Log(message: $"{numero} es par");

        }
        */



    }

   
}
