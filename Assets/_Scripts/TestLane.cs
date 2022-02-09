using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestLane : MonoBehaviour
{
    public MusicNote notePrefab;

    //Changing Y pos on Lane makes note appear faster
    public Vector2 spawnPosition;
    public Vector2 endPosition;
    public Vector2 removePosition;

    public Text debugBeatText;

    public float removeLineOffset = 3;

    //keep all the position-in-beats of notes in the song
    public int totalNotes = 0;
    public float[] notes;
    //the index of the next note to be spawned
    int noteNextIndex = 0;
    public int beatsShownInAdvance = 3;


    //List<MusicNote> notes = new List<MusicNote>();

    private void Start()
    {
        //spawnPosition = transform.position;
        //removePosition = new Vector2(transform.position.x, 0 - removeLineOffset);
        //endPosition = new Vector2(transform.position.x, 0);
        //notes = new float[totalNotes];
        //for(int i = 0; i < totalNotes; i++)
        //{
        //    notes[i] = i;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        debugBeatText.text = (SongManager.instance.songPosInBeats - SongManager.instance.beatOffset).ToString() ;
        //if (noteNextIndex < notes.Length && notes[noteNextIndex] < SongManager.instance.songPosInBeats + beatsShownInAdvance)
        //{
        //    // Instantiate( /* Music Note Prefab */ );
        //    MusicNote note = Instantiate(notePrefab);
        //    note.BeatsShownInAdvance = beatsShownInAdvance;
        //    note.RemovePos = removePosition;
        //    note.SpawnPos = spawnPosition;
        //    note.EndPos = endPosition;
        //    note.beatOfThisNote = notes[noteNextIndex];
        //    note.transform.parent = gameObject.transform;
        //    //initialize the fields of the music note
        //    noteNextIndex++;
        //}
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
