using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number : MonoBehaviour
{
     void Start()
{
    int counter = 0;
    while (counter < 20)
    {
        int randomNumber = Random.Range(1,21);
       Debug.Log(randomNumber);
       counter++;
       if (randomNumber == 5) continue;
       if (randomNumber == 15) break;

    }

}



}