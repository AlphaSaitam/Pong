using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (CompareTag("player 1"))
        {
            if (Input.GetKey(KeyCode.P))
            {
                transform.Translate(0.1f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.M))
            {
                transform.Translate(-0.1f, 0f, 0f);
            }
        }

        if (CompareTag("Player 2"))
        {
            if (Input.GetKey(KeyCode.Z))
            {
                transform.Translate(0.1f, 0f, 0f);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-0.1f, 0f, 0f);
            }
        }
        
        {
            
        }
    }
}
