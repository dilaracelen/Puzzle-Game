using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyun : MonoBehaviour
{
    int yerleştirilenParça;
    int toplamParça = 24;

    public void SayıArttır()
    {
        yerleştirilenParça++;

        if(yerleştirilenParça == toplamParça)
        {
            Debug.Log("Oyun Bitti");
        }
    }
}
