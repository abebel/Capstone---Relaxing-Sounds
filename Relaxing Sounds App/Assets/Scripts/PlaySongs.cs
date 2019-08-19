using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySongs : MonoBehaviour
{
    public GameObject test;
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public void PlayPauseSong()
    {
        if (!source.isPlaying)
        {
            source.Play();
        }
        else
        {
            source.Pause();
        }
    }
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = source.clip;
        source.playOnAwake = false;
        source.loop = true;

    }
}
