using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongSelectManager : MonoBehaviour
{
    public int selectedSongIndex;
    public SongInfo[] songInfoList;
    private SongInfo currentSong;
    private AudioSource audioSource;

    public Text songName;
    public Text songArtist;
    public Text songDifficulty;
    public Text songLength;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        selectedSongIndex = 0;
        currentSong = songInfoList[selectedSongIndex];
        audioSource.clip = currentSong.songAudioClip;
        songName.text = currentSong.songName;
        songArtist.text = currentSong.songArtist;
        songDifficulty.text = currentSong.songDifficulty;
        songLength.text = currentSong.songLength;
        audioSource.Play();
    }

    public void SelectSong(int songIndex)
    {
        SoundEffectManager.instance.PlaySoundEffect(0);
        selectedSongIndex = songIndex;
        currentSong = songInfoList[selectedSongIndex];
        songName.text = currentSong.songName;
        songArtist.text = currentSong.songArtist;
        songDifficulty.text = currentSong.songDifficulty;
        songLength.text = currentSong.songLength;
        //Fade out song, change background?
        audioSource.Play();
    }

    public void StartSong()
    {
        SoundEffectManager.instance.PlaySoundEffect(0);
        LoadManager.instance.LoadLevel(currentSong.songLevelToLoad);
    }

}
