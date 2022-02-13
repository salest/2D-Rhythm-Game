using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverPanel;
    public GameObject songOverPanel;
    public GameObject retryButton;
    public GameObject songSelectButton;
    public GameObject gradeImage;

    public Text songNameText;
    public Text maxComboText;
    public Text scoreText;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {           
            instance = this;
        }
    }

    public void OpenSongOverPanel()
    {
        //Play Sound Effect for song over
        //Play animation to open song over panel
        songOverPanel.GetComponent<Animator>().SetTrigger("songOver");
        retryButton.SetActive(true);
        gradeImage.SetActive(true);
        songSelectButton.SetActive(true);
        songNameText.text = SongManager.instance.songInfo.songName;
        maxComboText.text = "Max Combo: " + ScoreManager.Instance.maxCombo.ToString();
        scoreText.text = "Score: " + ScoreManager.Instance.comboScore.ToString();
        //Have animation panel show buttons after animation for opening panel is done
    }

    public void OpenGameOverPanel()
    {
        //Play Sound Effect for song over
        //Play animation to open song over panel
        gameOverPanel.GetComponent<Animator>().SetTrigger("songOver");
        //Have animation panel show buttons after animation for opening panel is done
    }
}
