using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource Musica;
    [SerializeField] AudioSource SFX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioClip backgroundMusic;
    public AudioClip SFXPuerta;
    public AudioClip SFXColeccion;
    public AudioClip SFXCompletar;

    void Start()
    {
        Musica.clip = backgroundMusic;
        Musica.loop = true;
        Musica.Play();
    }
}
