using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public float x_pos_lim = 5f;
    public GameObject sphere;
    public float time = 2f;
    private bool increase = true; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Control del movimiento de la esfera 
        if (increase)
        {
            sphere.transform.position += new Vector3((float)x_pos_lim / time * Time.fixedDeltaTime, 0, 0);
        }
        else 
        {
            sphere.transform.position -= new Vector3((float)x_pos_lim / time * Time.fixedDeltaTime, 0, 0);
        }

        // Cambio de los estados que determinan el sentido del movimiento
        if (sphere.transform.position.x >= x_pos_lim)
        {
            increase = false;
        }
        else if (sphere.transform.position.x <= -x_pos_lim)
        {
            increase = true; 
        }
    }
}
