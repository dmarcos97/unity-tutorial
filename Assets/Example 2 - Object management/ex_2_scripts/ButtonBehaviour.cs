using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public TMP_Text messageText;
    private int counter = 0;
    public GameObject sphere; 
    
    public void OnButtonClicked()
    {
        counter += 1;
        messageText.text = "Clicado: " + counter.ToString(); 
        if (sphere.active)
        {
            sphere.SetActive(false);
        }
        else
        {
            sphere.SetActive(true);
        }
    }
}
