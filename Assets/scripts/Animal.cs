using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int numberOfLegs = 4;

    [SerializeField] private string nameAnimal;

    [SerializeField] private bool hasMoreThanTwoLegs;

    //[SerializeField] private bool confir;



    private void Start()
    {
        /*
        Debug.Log(message:$"{nameAnimal} tiene {numberOfLegs} patas");

        Debug.Log(message: string.Format( "el {0} tine {1} patas", nameAnimal, numberOfLegs));
    
        Debug.Log(message: "el " + nameAnimal + " tiene " + numberOfLegs);
         */

        hasMoreThanTwoLegs = numberOfLegs >= 2;

        if (hasMoreThanTwoLegs == true)

        {
            Debug.Log(message: $"{nameAnimal} tine {numberOfLegs}patas: {hasMoreThanTwoLegs} ");

        }




    }





}

