using UnityEngine;
using TMPro;

public class FlavorButton : MonoBehaviour
{
    public string flavorText;
    public TextMeshProUGUI textContainer;
    private const int DELAY = 3000;

    public void OnClick()
    {
        textContainer.text = flavorText;
        textContainer.enabled = true;

        System.Threading.Thread.Sleep(DELAY);
        textContainer.enabled = false;
    }
}
