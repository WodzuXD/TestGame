using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptWithPlayerName : MonoBehaviour
{

    public KtoryTekst ktory;

    private Text tekst;
    public Gra game;

    public InputField playername;

    void Start()
    {
       
    }


    void Update()
    {
        tekst = gameObject.GetComponent<Text>();
        if (ktory == KtoryTekst.one)
        {
            tekst.text = game.name + ", interesujące... No dobra, Geruld, odprowadź " + game.name + "a do kwatery. Tracisz przytomność, budzisz się w kamiennym pokoju na wygodnym łożu";
        }
        if (ktory == KtoryTekst.two)
        {
            tekst.text = "Zatem. Witam Cię " + game.name + ", na naszej świętej ziemi. Witaj w Zakonie Pokrzywy!";
        }
        
    }


    public void SetName()
    {
        if (playername.text != "")
            game.name = playername.text;
        else
            game.name = "Derwan";
    }
}

public enum KtoryTekst
{
one, two
}
