using UnityEngine;
using System;

public class Backpack : MonoBehaviour
{
    public event Action GrabbedHomework; //objective completed

    public void OnClick()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
