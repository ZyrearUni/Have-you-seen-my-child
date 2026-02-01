using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Final : MonoBehaviour
{
    public Animator anim;
    public GameObject TextoFinal;
    public void BotonPulsado()
   {
     TextoFinal.SetActive(true);
     anim.Play("Final");
     Invoke("Mover", 3.5f);
   }
    void Mover()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
