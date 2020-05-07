using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoleLevelTwo : MonoBehaviour
{
    Text scoreBox; 
   public int score;
    void Start()
    {

        GameObject scoreObject = GameObject.Find("ScoreObject");
        ScoreController scoreCon = scoreObject.GetComponent<ScoreController>();
        score = scoreCon.score; 
        scoreBox = GameObject.Find("Text").GetComponent<Text>(); }

    
    //load score at level two, get previous score from level one from score conreoller and add new score from "enemies" script
    public void Update()
    { 
        GameObject scoreee = GameObject.FindWithTag("enemy");
        enemies scoreR = scoreee.GetComponent<enemies>();
        int newscore = scoreR.currentscorer;
        int scorescore = score + newscore;
        scoreBox.text = "Score" + scorescore.ToString();
        


    }
}