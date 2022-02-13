using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SongPositionBar : MonoBehaviour
{
    private Slider slider;
    

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (SongManager.instance.songEnded || !SongManager.instance.songStarted) return;
        slider.value = SongManager.instance.songPosInBeats / SongManager.instance.endOfSongInBeats;
        
    }
}
