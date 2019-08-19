using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeSettings : MonoBehaviour
{
    public GameObject Panel;

    public void OpenVolumeSettings()
    {
        Panel.SetActive(true);
    }
    public void CloseVolumeSettings()
    {
        Panel.SetActive(false);
    }
}
