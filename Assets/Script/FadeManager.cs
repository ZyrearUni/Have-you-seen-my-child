using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FadeManager : MonoBehaviour 
{

    public GameObject fade;

    public void destruir()
    {
        fade.SetActive(false) ;
    }
} 
