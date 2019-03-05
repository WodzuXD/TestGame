using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gra : MonoBehaviour
{
    public int scena = 0;
    public string name = "Derwan";
    public GameObject[] panel;

    public InputField playername;

    void Start()
    {
        
    }

    void Update()
    {
        for (int i = 0; i < panel.Length; i++)
        {
            if (i == scena)
                panel[i].active = true;
            else
                panel[i].active = false;
        }
    }

    public void Wybor(int i)
    {
        scena = i;
    }

    public void SetName()
    {
        if (playername.text != "")
            name = playername.text;
        else
            name = "Derwan";
    }
}
