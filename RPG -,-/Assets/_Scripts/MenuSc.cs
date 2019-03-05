using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSc : MonoBehaviour
{
    public int window = 0;

    public GameObject[] okienko;

    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < okienko.Length; i++)
        {
            if (i == window)
            {
                okienko[i].active = true;
            }
            else
                okienko[i].active = true;
        }
    }

    public void StartGame()
    {

    }
}
