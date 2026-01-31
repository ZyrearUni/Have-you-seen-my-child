using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class obtainmask : MonoBehaviour
{
    public GameObject botonMascara;
    public GameObject botonSalirHabitacion;
    public void OnClick()
    {
        botonMascara.SetActive(true);
        botonSalirHabitacion.SetActive(true);
        
        Destroy(transform.parent.gameObject);
    }
}
