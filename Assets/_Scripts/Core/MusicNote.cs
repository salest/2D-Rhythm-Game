using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MusicNote : MonoBehaviour
{

    enum NoteType { Score, Obstacle, SpaceNote}
    [SerializeField] NoteType noteType; 

    double timeInstantiated;
    public float assignedTime;
    public float moveSpeed = 5f;
    public float damagePoints = 10f;

    public Vector2 SpawnPos;
    public Vector2 RemovePos;
    public Vector2 EndPos;

    public float beatOfThisNote;
    public int BeatsShownInAdvance;

    private bool canBePressed = false;
    private Player player;

    public GameObject explosionEffect;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(noteType == NoteType.SpaceNote && canBePressed == true && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            ScoreManager.Instance.HitSpace();
            DestroyMusicNote();
        }
        //transform.Translate(moveSpeed * Vector2.down * Time.deltaTime);

        //transform.position = Vector2.Lerp(
        //    SpawnPos,
        //    RemovePos,
        //    (BeatsShownInAdvance - (beatOfThisNote - SongManager.instance.songPosInBeats)) / BeatsShownInAdvance
        //    );

        transform.position = new Vector2(SpawnPos.x, SpawnPos.y + (EndPos.y - SpawnPos.y) * (1f - (beatOfThisNote - SongManager.instance.songPosition / SongManager.instance.secPerBeat) / BeatsShownInAdvance) + SongManager.instance.beatOffset);

        if (transform.position.y <= RemovePos.y)
        {
            if(noteType == NoteType.Score || noteType == NoteType.SpaceNote)
            {
                //Miss, Break Combo
                ScoreManager.Instance.Miss();
            }
            Destroy(gameObject);
        }
    }

    public void DestroyMusicNote()
    {
        if (noteType == NoteType.Score)
        {
            var explode = Instantiate(explosionEffect, transform.position, transform.rotation);
        }
        else if(noteType == NoteType.SpaceNote)
        {
            var explode = Instantiate(explosionEffect, player.transform.position, player.transform.rotation);
        }
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (noteType == NoteType.SpaceNote)
        {
            if(collision.tag == "BottomBar")
            {
                canBePressed = true;
            }
        }
        else
        {
            if (collision.tag == "Player")
            {
                if (noteType == NoteType.Score)
                {
                    ScoreManager.Instance.HitNormal();
                    DestroyMusicNote();
                }
                else if (noteType == NoteType.Obstacle)
                {
                    player.TakeDamage(damagePoints);
                    DestroyMusicNote();
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (noteType == NoteType.SpaceNote)
        {
            if (collision.tag == "BottomBar")
            {
                canBePressed = false;
            }
        }
    }
}
