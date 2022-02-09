using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongVolume : MonoBehaviour
{
    enum VolumeType {Song, Sfx, Voice }
    [SerializeField]
    VolumeType volumeType;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(volumeType == VolumeType.Song)
        {
            audioSource.volume = VolumeManager.instance.songVolume;
        }
        else if(volumeType == VolumeType.Voice)
        {
            audioSource.volume = VolumeManager.instance.voiceVolume;
        }
        else if (volumeType == VolumeType.Sfx)
        {
            audioSource.volume = VolumeManager.instance.sfxVolume;
        }
        
    }

}
