using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
public class CodigoMenuPrim : MonoBehaviour
{
    public GameObject MenuConfig;
    public GameObject MenuPrincipal;
    public Animator anim;
    // Boton para empezar el juego
    public void Jugar()
    {
        anim.Play("FadeOut");
        Invoke("CargarNivel", 1f);
       
    }
    void CargarNivel()
    {
        //Cargar la escena del nivel
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
    }
    // Boton para volver al menu principal
    public void Volver()
    {
        //Quitar el menu de configuraciones y activar el principal
        MenuConfig.SetActive(false);
        MenuPrincipal.SetActive(true);
    }
}
