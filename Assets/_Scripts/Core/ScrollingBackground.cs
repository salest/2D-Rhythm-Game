using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isStartTile = false;
    public float yStopLine = -22;
    public float tilemapStartY = 22f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!SongManager.instance.songStarted) return;
        if (transform.position.y <= yStopLine && isStartTile)
        {
            gameObject.SetActive(false);
        }

        else if(transform.position.y <= yStopLine && !isStartTile)
        {
            transform.position = new Vector3(transform.position.x, tilemapStartY, transform.position.z);
        }
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
    }
}
