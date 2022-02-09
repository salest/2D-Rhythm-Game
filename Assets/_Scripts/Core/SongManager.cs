using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Networking;
using System;

public class SongManager : MonoBehaviour
{
    public static SongManager instance;

    public Lane[] lanes;


    /*
     * Song Information
     */
    [Header("Song Information")]
    public AudioSource audioSource;
    public AudioSource endingSongSource;
    public AudioSource gameOverSongSource;
    // BPM of song
    public float bpm;
    //the current position of the song (in seconds)
    public float songPosition;
    //the current position of the song (in beats)
    public float songPosInBeats;
    //the duration of a beat
    public float secPerBeat;
    //how much time (in seconds) has passed since the song started
    public float dsptimesong;
    public bool songStarted = false;
    public bool songEnded = false;
    public float beatOffset = 4;

    //Song length
    private float songLengthInSec;
    public float songLengthInBeats;
    public float endOfSongInBeats = 0;

    /*
     * Input Delay Variables
     */
    [Header("Input Delay Variables")]
    public int songDelayInSecongs;
    public double marginOfError;
    public int inputDelayInMilliseconds;

    [Header("Countdown Variables")]
    public GameObject countDownNumber;
    private SpriteRenderer countDownSprite;
    private Animator countDownAnimator;
    public Sprite[] numberSpirtes;
    private int spriteIndex = 0;
   
    public float noteTime;
    public float noteSpawnY;
    public float noteTapY;

    //Manage player sprite depending if game over/song cleared
    private Player player;

    void Awake()
    {
        instance = this;
        StartCoroutine(StartCountDown(songDelayInSecongs));
        countDownAnimator = countDownNumber.GetComponent<Animator>();
        countDownSprite = countDownNumber.GetComponent<SpriteRenderer>();
        //calculate how many seconds is one beat
        secPerBeat = 60f / bpm;
        spriteIndex = 6 - songDelayInSecongs;
        songPosInBeats = songPosInBeats + beatOffset;
        endOfSongInBeats = endOfSongInBeats + beatOffset; 

        songLengthInSec = audioSource.clip.length;
        songLengthInBeats = songLengthInSec / secPerBeat;

        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if (songStarted)
        {
            //calculate the position in seconds
            songPosition = (float)(AudioSettings.dspTime - dsptimesong);
            //calculate the position in beats
            songPosInBeats = (songPosition / secPerBeat) + beatOffset;
            //Start Fade Out Of Song
            if(songPosInBeats > endOfSongInBeats)
            {
                StartCoroutine(StartFade(audioSource, 3f, 0f));
            }
            //Stop Animation Triggers and Open Cleared Song Panel
            if(songPosInBeats > endOfSongInBeats + 8f)
            {
                EndSong();
            }
        }
    }


    private void EndSong()
    {
        songStarted = false;       
        songEnded = true;
        player.SetAnimationBool("songStarted", false);
        GameManager.instance.OpenSongOverPanel();
        endingSongSource.Play();
        Debug.Log("Song Finished");
    }

    private void StartSong()
    {
        //record the time when the song starts
        dsptimesong = (float)AudioSettings.dspTime;
        //start the song
        songStarted = true;
        player.SetAnimationBool("songStarted", true);
        audioSource.Play();
    }

    private IEnumerator StartCountDown(int seconds)
    {
        int counter = seconds;
        while (counter > 0)
        {          
            yield return new WaitForSeconds(1);
            counter--;
            countDownAnimator.SetTrigger("openCountdown");
            countDownSprite.sprite = numberSpirtes[spriteIndex];
            spriteIndex++;
            if(counter == 0)
            {
                countDownAnimator.SetTrigger("closeCountdown");
            }
        }
        StartSong();
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

    public void StopSongGameOver()
    {
        songStarted = false;
        songEnded = true;
        player.SetAnimationTrigger("gameOver");
        GameManager.instance.OpenGameOverPanel();
        audioSource.Stop();
        gameOverSongSource.Play();
    }


    public static double GetAudioSourceTime()
    {
        return (double) instance.audioSource.timeSamples / instance.audioSource.clip.frequency;
    }




}
