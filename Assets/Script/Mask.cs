using UnityEngine;
using System.Collections.Generic;

public class Mask : MonoBehaviour
{
    public bool isMaskOn = false;
    public List<GameObject> buttons;    

    public void OnClick()
    {
        isMaskOn = !isMaskOn;

        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].SetActive(isMaskOn);
        }
    }
}
