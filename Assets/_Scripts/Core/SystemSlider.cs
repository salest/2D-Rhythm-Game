using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemSlider : MonoBehaviour
{
    public Slider songSlider;
    public Slider sfxSlider;
    public Slider voiceSlider;

    public SoundEffectManager soundEffectManager;
    private AudioSource audioSource;
    private bool firstLoad = true;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartFade(audioSource, 0.5f, VolumeManager.instance.songVolume);
        songSlider.value = VolumeManager.instance.songVolume;
        sfxSlider.value = VolumeManager.instance.sfxVolume;
        voiceSlider.value = VolumeManager.instance.voiceVolume;
    }

    public void UpdateSongVol()
    {
        VolumeManager.instance.songVolume = songSlider.value;
        audioSource.volume = VolumeManager.instance.songVolume;
    }
    public void UpdateSfxVol()
    {
        VolumeManager.instance.sfxVolume = sfxSlider.value;
        soundEffectManager.audioSource.volume = sfxSlider.value;
        if (firstLoad)
        {
            firstLoad = false;
        }
        else
        {
            soundEffectManager.PlaySoundEffect(0);
        }
        
    }
    public void UpdateVoiceVol()
    {
        VolumeManager.instance.voiceVolume = voiceSlider.value;
    }
    public void SaveSettings()
    {

    }

    public IEnumerator StartFade(AudioSource audioSource, float duration, float targetVolume)
    {
        Debug.Log("StartFade has started");
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

}
