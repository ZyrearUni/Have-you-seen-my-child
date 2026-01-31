using UnityEngine;
using UnityEngine.UI;
using System;

public class Bag : MonoBehaviour
{
    private bool hasGocata = false;
    private bool hasMansana = false;
    private bool hasMedisina = false;

    public Sprite fullBag;

    public void OnClick()
    {
        if (hasGocata && hasMansana && hasMedisina)
        {
            transform.parent.GetComponent<Image>().sprite = fullBag;
        }
    }

    public void Gocata()
    {
        hasGocata = true;
        this.Enable();
    }

    public void Mansana()
    {
        hasMansana = true;
        this.Enable();
    }

    public void Medisina()
    {
        hasMedisina = true;
        this.Enable();
    }

    private void Enable()
    {
        if (hasGocata && hasMansana && hasMedisina)
        {
            transform.parent.GetComponent<Button>().interactable = true;
        }
    }

}
