using UnityEngine;
using System;

public class Bag : MonoBehaviour
{
    public event Action MadeLunch; //objective completed

    public void OnClick()
    {
        MadeLunch.Invoke();
        transform.parent.gameObject.SetActive(false);
    }

}
