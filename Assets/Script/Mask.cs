using UnityEngine;
using System.Collections.Generic;

public class Mask : MonoBehaviour
{
    public bool isMaskOn = false;
    public List<GameObject> maskedItems;
    public List<GameObject> unmaskedItems;
    public List<GameObject> spriteChange;
    public List<Sprite> sprites;
    public Animator anim;
    public GameObject animPonermask;

    public void OnClick()
    {
        isMaskOn = !isMaskOn;

        if (isMaskOn == true)
        {
            animPonermask.SetActive(true);
            anim.Play("PonerMascara");
        }
        if (isMaskOn == false)
        {
            animPonermask.SetActive(true);
            anim.Play("QuitarMascara");
        }

        Invoke("ChangeSprites", 2f);
    }

    private void ChangeSprites()
    {
        for (int i = 0; i < maskedItems.Count; i++)
        {
            maskedItems[i].SetActive(isMaskOn);
        }

        for (int i = 0; i < unmaskedItems.Count; i++)
        {
            unmaskedItems[i].SetActive(!isMaskOn);
        }
      
        /*
         * TODO: Make this shit work well
         * 
        for (int i = 0; i < spriteChange.Count; i++)
        {
            spriteChange[i].GetComponent<SpriteRenderer>().sprite = sprites[i];
        }*/
    }
}
