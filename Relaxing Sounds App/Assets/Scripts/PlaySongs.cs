using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySongs : MonoBehaviour
{
    public GameObject ButtonText;
    public Button button;
    public Sprite MusicOffImage;
    public Sprite MusicOnImage;
    public GameObject VolumeSlider;
    public AudioSource Source { get { return GetComponent<AudioSource>(); } }
    public void PlayPauseSong()
    {
        if (!Source.isPlaying)
        {
            Source.Play();
            VolumeSlider.SetActive(true);
            ButtonText.SetActive(false);
            button.GetComponent<Image>().sprite = MusicOnImage;
        }
        else
        {
            Source.Pause();
            VolumeSlider.SetActive(false);
            ButtonText.SetActive(true);
            button.GetComponent<Image>().sprite = MusicOffImage;
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
