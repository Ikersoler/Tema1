using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{

    /*comentario multilinea 
     * -
     * -
     */

   [SerializeField] private int age = 18; // valor predeterminado =0;

    [SerializeField] private float speed = 1.5f; // valor predeterminado =0.0f;
    //poner una f final al finarl de una variable float

    [SerializeField] private bool isGameOver = false; // valor predeterminado = false

    [SerializeField] private string userName = "federico"; // valor predeterminado = ""

    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private int coins;

    [SerializeField] private int hour;


    private void Start()
    {
        /*
        Debug.Log(message:"Hola, mundo");
        Debug.Log(userName);
        Debug.Log(age);
        Debug.Log(speed);
        Debug.Log(isGameOver);

        //Forma 1
        Debug.Log(message: $"El nombre del usuario es: ¨{userName}");


        //Forma2
        Debug.Log(message: string.Format("la velocida del usuario es {0} m/s Que rapido es {1}", speed, userName));


        //Forma3
        Debug.Log(message:"El usuario tiene " + age + " años.");
        */

        /*
        Debug.Log(message: 2 + 5);

        Debug.Log(message: num1 + num2);

        Debug.Log(message:num1 + 10);

        Debug.Log(message: coins + 10);

        Debug.Log(message:$"monedas: {coins}");
        //coins = coins + 10;
        coins += 10;
        Debug.Log(message:$"monedas: {coins}");
        */
        /*
        Debug.Log(message: $"{num1} + {num2} = {num1 + num2} ");
        Debug.Log(message: $"{num1} - {num2} = {num1 - num2} ");
        Debug.Log(message: $"{num1} * {num2} = {num1 * num2} ");
        Debug.Log(message: $"{num1} / {num2} = {num1 / num2} ");

        /*
        //+= sumar
        coins = coins + 5;

        coins += 5;

        coins++; //añade 1

        //-= restar
        coins = coins - 5;

        coins -= 5;

        coins--; //resta 1

        //*= multiplicar
        coins = coins * 5;

        coins *= 5;

        ///= dividir
        coins = coins / 5;

        coins /= 5;
        */

        Debug.Log(message: hour % 12);



    }


}
