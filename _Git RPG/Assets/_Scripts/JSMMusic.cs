using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSMMusic : MonoBehaviour
{

    public AudioClip[] muzykaJSM;

    int numer = 0;

    public bool gra = false;

    float timer = 0f;
    float dlugoscPiosenki = 0f;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (!gra)
        {
            dlugoscPiosenki = muzykaJSM[numer].length;
            timer = 0f;
            MuzyczkaJSM();
            gra = true;
        }
        if (timer >= dlugoscPiosenki)
            numer = Random.Range(0, muzykaJSM.Length); gra = false;

        timer += Time.deltaTime;
    }

    void MuzyczkaJSM()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(muzykaJSM[numer]);
    }
}
