using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    public int currentscorer = 1;
   

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentscorer = 0;

    }

    //send no of enemies to score text at level 2
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bluebullets")
        {
//send score to load score of level two
            GameObject scoreObject = GameObject.Find("ScoreObject");
            scoleLevelTwo scoreCon = scoreObject.GetComponent<scoleLevelTwo>();
            scoreCon.score +=1;

        }
    }


}