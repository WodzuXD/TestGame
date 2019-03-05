using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptWithPlayerName : MonoBehaviour
{
    public Text tekst;
    public Gra game;

    void Start()
    {
       
    }


    void Update()
    {
        tekst.text = game.name + ", interesujące... No dobra, Geruld, odprowadź " + game.name + "a do kwatery. Tracisz przytomność, budzisz się w kamiennym pokoju na wygodnym łożu";
    }
}
