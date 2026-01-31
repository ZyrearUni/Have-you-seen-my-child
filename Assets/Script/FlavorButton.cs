using UnityEngine;
using TMPro;

public class FlavorButton : MonoBehaviour
{
    public string flavorText;
    public TextMeshProUGUI textContainer;
    private const float DELAY = 2f;

    public void OnClick()
    {
        textContainer.text = flavorText;
        textContainer.enabled = true;

        Invoke("DisableText", DELAY);
    }

    private void DisableText()
    {
        textContainer.enabled = false;
    }
}
