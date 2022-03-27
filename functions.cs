using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
    // Start is called before the first frame update

    float a = 2;
    float b = 2;

    void Start()
    {

     float summary = Sum(2,2);
     float product = Prod(2,2);

    }

    // Update is called once per frame
    void Update()
    {

    }

    float Sum(float a,float b){

        float c = a+b;

            return c;
    }

    float Prod(float a,float b){

        float c = a*b;

            return c;

    }
     float Div(float a,float b){

         if(c = a/b){

            return c;

         }else(b = 0){

             Debug.Log("error");

         }

     }

}