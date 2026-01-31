using UnityEngine;
using System;

public class Backpack : MonoBehaviour
{
    public Sprite fullBackpack;

    public void OnClick()
    {
        transform.parent.gameObject.SetActive(false);
    }

    private void Enable()
    {
        transform.parent.getComponent<Button>().interactable = true;
    }
}
