using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Lane : MonoBehaviour
{

    public MusicNote notePrefab;
    public MusicNote obstaclePrefab;

    //Changing Y pos on Lane makes note appear faster
    public Vector2 spawnPosition;
    public Vector2 endPosition;
    public Vector2 removePosition;
   
    public float removeLineOffset = 3;

    //keep all the position-in-beats of notes in the song
    public float[] notes;
    public float[] obstacles;
    //the index of the next note to be spawned
    int noteNextIndex = 0;
    int obstacleNextIndex = 0;
    public int beatsShownInAdvance = 3;


    //List<MusicNote> notes = new List<MusicNote>();

    private void Start()
    {
        spawnPosition = transform.position;
        removePosition = new Vector2(transform.position.x, 0 - removeLineOffset);
        endPosition = new Vector2(transform.position.x, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (noteNextIndex < notes.Length && notes[noteNextIndex] < SongManager.instance.songPosInBeats + beatsShownInAdvance)
        {
            // Instantiate( /* Music Note Prefab */ );
            MusicNote note = Instantiate(notePrefab);
            note.BeatsShownInAdvance = beatsShownInAdvance;
            note.RemovePos = removePosition;
            note.SpawnPos = spawnPosition;
            note.EndPos = endPosition;
            note.beatOfThisNote = notes[noteNextIndex];
            note.transform.parent = gameObject.transform;
            //initialize the fields of the music note

            noteNextIndex++;
        }

        if (obstacleNextIndex < obstacles.Length && obstacles[obstacleNextIndex] < SongManager.instance.songPosInBeats + beatsShownInAdvance)
        {
            // Instantiate( /* Music Note Prefab */ );
            MusicNote obstacle = Instantiate(obstaclePrefab);
            obstacle.BeatsShownInAdvance = beatsShownInAdvance;
            obstacle.RemovePos = removePosition;
            obstacle.SpawnPos = spawnPosition;
            obstacle.EndPos = endPosition;
            obstacle.beatOfThisNote = obstacles[obstacleNextIndex];
            obstacle.transform.parent = gameObject.transform;
            //initialize the fields of the music note

            obstacleNextIndex++;
        }
    }


    //Score Manager Update
    //private void Hit()
    //{
    //    ScoreManager.Hit();
    //}
    //private void Miss()
    //{
    //    ScoreManager.Miss();
    //}
}

