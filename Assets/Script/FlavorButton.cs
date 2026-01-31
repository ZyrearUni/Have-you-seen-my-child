using UnityEngine;
using TMPro;

public class FlavorButton : MonoBehaviour
{
    public string flavorText;
    public TextMeshPro textContainer;
    private const int DELAY = 3000;

    public void OnClick()
    {
        textContainer.text = flavorText; 
        textContainer.SetEnabled(true);

        System.Threading.Thread.Sleep(DELAY);
        //textContainer.SetActive(false);
    }
}
