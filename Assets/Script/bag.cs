using UnityEngine;
using System;

public class Bag : MonoBehaviour
{
    private bool hasGocata = false;
    private bool hasMansana = false;
    private bool hasMedisina = false;

    public event Action MadeLunch; //objective completed

    public Sprite fullBag;

    public void OnClick()
    {
        if (hasGocata && hasMansana && hasMedisina)
        {
            MadeLunch.Invoke();
            transform.parent.GetComponent<SpriteRenderer>().sprite = fullBag;
        }
    }

    public void Gocata()
    {
        hasGocata = true;
    }

    public void Mansana()
    {
        hasMansana = true;
    }

    public void Medisina()
    {
        hasMedisina = true;
    }

}
