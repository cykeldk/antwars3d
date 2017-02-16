using System.Collections;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent (typeof(AudioSource))]

public class BackgroundVideo : MonoBehaviour
{
    public MovieTexture movie;
    private AudioSource audio;

    void Start()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        movie.Play();
        audio.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && movie.isPlaying)
        {
            movie.Pause();
        }

        if (Input.GetKeyDown(KeyCode.Space) && !movie.isPlaying)
        {
            movie.Play();
        }


    }
}
