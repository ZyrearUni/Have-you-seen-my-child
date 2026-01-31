using UnityEngine;
using UnityEngine.UI;
using System;

public class Backpack : MonoBehaviour
{
    private bool hasHomework = false;

    public Sprite fullBackpack;

    public void OnClick()
    {
        if (hasHomework)
        {
            transform.parent.GetComponent<Image>().sprite = fullBackpack;
        }
    }

    private void Enable()
    {
        transform.parent.GetComponent<Button>().interactable = true;
    }
}
