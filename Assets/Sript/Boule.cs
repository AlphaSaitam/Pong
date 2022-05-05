
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boule : MonoBehaviour
{
    public Rigidbody2D RD;
    public float speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        RD = GetComponent<Rigidbody2D>();
        RD.AddForce(transform.right*speed, ForceMode2D.Impulse);
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
