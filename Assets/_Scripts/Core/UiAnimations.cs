using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiAnimations : MonoBehaviour
{
    public GameObject[] buttons;
    public void ShowButtons()
    {
        foreach (GameObject button in buttons)
        {
            button.SetActive(true);
        }
    }
}
