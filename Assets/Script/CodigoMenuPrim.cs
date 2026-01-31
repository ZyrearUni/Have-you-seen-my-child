using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class CodigoMenuPrim : MonoBehaviour
{
    public GameObject MenuConfig;
    public GameObject MenuPrincipal;
    public Animator anim;
    public GameObject fade;
    public GameObject Imagen;
    // Boton para empezar el juego
    public void Jugar()
    {
        Imagen.SetActive(true);
        fade.SetActive(true);
        MenuPrincipal.SetActive(false);
        anim.Play("FadeOut");
        Invoke("CargarNivel", 1.6f);
    }
    void CargarNivel() 
    {
        
        SceneManager.LoadScene("Nivel");
    }

    // Boton para salir del juego
    public void Salir()
    {
        // Salir de la aplicacion
        Application.Quit();
    }
    // Boton para abrir el menu de configuraciones
    public void Configuraciones()
    {
        //Quitar el menu principal y activar el de configuraciones
        MenuConfig.SetActive(true);
        MenuPrincipal.SetActive(false);
        Imagen.SetActive(false);
    }
    // Boton para volver al menu principal
    public void Volver()
    {
        //Quitar el menu de configuraciones y activar el principal
        MenuConfig.SetActive(false);
        MenuPrincipal.SetActive(true);
        Imagen.SetActive(true);
    }
}
