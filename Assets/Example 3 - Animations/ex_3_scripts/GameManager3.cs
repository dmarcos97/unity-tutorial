using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager3 : MonoBehaviour
{
    public int nClick = 0;
    public GameObject zombie;
    private Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        animator = zombie.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (nClick > 3)
        {
            nClick = 0; 
        }

        animator.SetFloat("Clicks", nClick);
    }
}
