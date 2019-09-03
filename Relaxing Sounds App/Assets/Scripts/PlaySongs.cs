using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySongs : MonoBehaviour
{
    public GameObject ButtonText;
    public GameObject VolumeSlider;
    public AudioSource Source { get { return GetComponent<AudioSource>(); } }
    public void PlayPauseSong()
    {
        if (!Source.isPlaying)
        {
            Source.Play();
            VolumeSlider.SetActive(true);
            ButtonText.SetActive(false);
        }
        else
        {
            Source.Pause();
            VolumeSlider.SetActive(false);
            ButtonText.SetActive(true);
        }
    }
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        Source.clip = Source.clip;
        Source.playOnAwake = false;
        Source.loop = true;

    }
}
