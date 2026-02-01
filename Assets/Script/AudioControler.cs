using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class AudioControler : MonoBehaviour
{
    [SerializeField] private AudioMixer Mixer;
    [SerializeField] private Slider musicSlider;

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        Mixer.SetFloat("Sonido", volume);
    }
}
