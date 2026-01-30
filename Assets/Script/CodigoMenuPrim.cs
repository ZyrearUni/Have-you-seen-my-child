using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class CodigoMenuPrim : MonoBehaviour
{
    public GameObject MenuConfig;
    public GameObject MenuPrincipal;
    public void Jugar()
    {
        SceneManager.LoadScene("Nivel");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Configuraciones()
    {
        MenuConfig.SetActive(true);
        MenuPrincipal.SetActive(false);
    }
    public void Volver()
    {
        MenuConfig.SetActive(false);
        MenuPrincipal.SetActive(true);
    }
}
