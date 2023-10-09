using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{

    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private int num;

    //[SerializeField] private float result;


    private void Start()
    {

        Debug.Log(message: $"{num1} + {num2} = {num1 + num2}");
        Debug.Log(message: $"{num1} - {num2} = {num1 - num2}");
        Debug.Log(message: $"{num1} * {num2} = {num1 * num2}");
        Debug.Log(message: $"{num1} / {num2} = {num1 / num2}");

        Debug.Log(message: num % 2);



    }


}
