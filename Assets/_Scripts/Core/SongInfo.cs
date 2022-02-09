using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SongInfo", menuName = "ScriptableObjects/SongInfo", order = 1)]
public class SongInfo : ScriptableObject
{
    public string songName;
    public string songArtist;
    public string songDifficulty;
    public string songLength;
    public AudioClip songAudioClip;
    public int songLevelToLoad = 1;
}
