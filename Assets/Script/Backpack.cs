using UnityEngine;
using System;

public class Backpack : MonoBehaviour
{
    public event Action GrabbedHomework; //objective completed

    public void OnClick()
    {
        GrabbedHomework.Invoke();
        transform.parent.gameObject.SetActive(false);
    }
}
