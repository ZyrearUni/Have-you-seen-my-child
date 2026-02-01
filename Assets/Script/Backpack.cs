using UnityEngine;
using UnityEngine.UI;
using System;

public class Backpack : MonoBehaviour
{
    private bool hasHomework = false;
    private bool hasReports = false;

    public Sprite fullBackpack;

    public void OnClick()
    {
        if (hasHomework)
        {
            transform.parent.GetComponent<Image>().sprite = fullBackpack;
        }
    }

    public void Deberes()
    {
        hasHomework = true;
        Enable();
    }

    public void Reportes()
    {
        hasReports = true;
        Enable();
    }

    private void Enable()
    {
        if (hasHomework && hasReports)
        {
            transform.parent.GetComponent<Button>().interactable = true;
        }
    }
}
