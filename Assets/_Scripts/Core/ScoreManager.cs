using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public AudioSource[] hitSFX;
    public AudioSource missSFX;
    public Text scoreText;
    public Text comboText;
    public int comboScore;
    public static int baseScore = 300;
    static int currentCombo;
    public int maxCombo;

    Player player;

    void Start()
    {
        Instance = this;
        comboScore = 0;
        currentCombo = 0;
        maxCombo = 0;
        scoreText.text = $"SCORE: {comboScore.ToString()}";
        comboText.text = $"COMBO: {currentCombo.ToString()}";
        player = FindObjectOfType<Player>();
    }
    public void HitNormal()
    {
        CheckForCombo();
        currentCombo++;
        CheckMaxCombo();
        comboScore = comboScore + currentCombo * baseScore;
        scoreText.text = $"SCORE: {comboScore.ToString()}";
        comboText.text = $"COMBO: {currentCombo.ToString()}";
        Instance.hitSFX[0].Play();
    }

    public void HitSpace()
    {
        CheckForCombo();
        currentCombo++;
        CheckMaxCombo();
        comboScore = comboScore + currentCombo * baseScore;
        scoreText.text = $"SCORE: {comboScore.ToString()}";
        comboText.text = $"COMBO: {currentCombo.ToString()}";
        Instance.hitSFX[1].Play();
    }


    public void Miss()
    {
        currentCombo = 0;
        scoreText.text = $"SCORE: {comboScore.ToString()}";
        comboText.text = $"COMBO: {currentCombo.ToString()}";
        //Instance.missSFX.Play();
    }

    public void BreakCombo()
    {
        currentCombo = 0;
        comboText.text = $"COMBO: {currentCombo.ToString()}";
    }

    private void CheckMaxCombo()
    {
        if(currentCombo > maxCombo)
        {
            maxCombo = currentCombo;
        }
    }

    private void CheckForCombo()
    {
        if (player.currentHealth == 100) return;
        
        if(currentCombo != 0 && currentCombo % (player.comboHealthRegen - 1) == 0)
        {
            //Play Regen Sound Effect
            player.currentHealth += 5;
        }

        switch (currentCombo)
        {
            case 50:
                //Play Combo Sound Effect
                break;
            case 100:
                break;
            case 150:
                break;
            case 200:
                break;
            default:
                break;
        }
    }
}
