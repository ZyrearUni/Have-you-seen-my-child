using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class Mask : MonoBehaviour
{
    public bool isMaskOn = false;
    public List<GameObject> maskedItems;
    public List<GameObject> unmaskedItems;
    public List<GameObject> spriteChange;

    [System.Serializable]
    public class serializableSprites
    {
        public List<Sprite> spriteToggle;
    }
    public List<serializableSprites> sprites;

    public List<GameObject> addFilter;

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

        Invoke("ChangeSprites", 1f);
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
      
       
        for (int i = 0; i < spriteChange.Count; i++)
        {
            int j = isMaskOn ? 0 : 1;
            //spriteChange[i].GetComponent<Image>().sprite = sprites[i].spriteToggle[j];
        }

        for (int i = 0; i < addFilter.Count; i++)
        {

        }
    }
}
