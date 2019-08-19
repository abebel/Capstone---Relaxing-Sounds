using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetVolume (float volume)
    {
        mixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }
}
