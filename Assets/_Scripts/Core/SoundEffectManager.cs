using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManager : MonoBehaviour
{
    public static SoundEffectManager instance;
    public AudioClip[] soundEffectArray;
    public AudioSource audioSource;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(instance);
        }
    }

    public void PlaySoundEffect(int soundToPlay)
    {
        audioSource.clip = soundEffectArray[soundToPlay];
        audioSource.Play();
    }
}
