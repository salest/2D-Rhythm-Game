using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("Player Life Variables")]
    public float currentHealth;
    public float maxHealth = 100f;
    public bool isInvul = false;

    private Animator animator;

    private void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();       
    }


    public void TakeDamage(float damage)
    {
        if (isInvul) return;
        ScoreManager.Instance.BreakCombo();
        if(currentHealth - damage <= 0)
        {
            //GameOver
            SongManager.instance.StopSongGameOver();
            currentHealth = 0;
            Debug.Log("Game Over");
        }
        else
        {
            currentHealth -= damage;
            currentHealth = Mathf.RoundToInt(currentHealth);
            StartCoroutine(StartInvincible());          
        }
    }

    private IEnumerator StartInvincible()
    {
        isInvul = true;
        animator.SetBool("isInvul", isInvul);
        yield return new WaitForSeconds(1.5f);
        isInvul = false;
        animator.SetBool("isInvul", isInvul);
    }


    public void SetAnimationBool(string animation, bool state)
    {
        animator.SetBool(animation, state);
    }

    public void SetAnimationTrigger(string animation)
    {
        animator.SetTrigger(animation); 
    }

}
