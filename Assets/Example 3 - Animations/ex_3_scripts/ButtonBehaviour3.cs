using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour3 : MonoBehaviour
{
    private GameManager3 manager;

    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager3>();
    }

    public void IncreaseNClick()
    {
        manager.nClick += 1; 
    }
}
