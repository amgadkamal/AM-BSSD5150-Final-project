using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stomp : MonoBehaviour
{
    public int currentscore = 0;
  
    void Update()
    {
        //with each stomp enemy increase the score
        GameObject scoreObj = GameObject.Find("ScoreObject");
        if (scoreObj != null)
        {
            ScoreController scoreC = scoreObj.GetComponent<ScoreController>();
            scoreC.score = currentscore; } }
    
    
    
    void OnTriggerEnter2D(Collider2D other)

    {//is score 3 and trigger map move to level two
        if (other.gameObject.tag == "map" & currentscore==3)
        {
            SceneManager.LoadScene("leveltwo");
        }
//increase the score with each stomp
        if (other.gameObject.tag == "virus")
        { currentscore += 1; 
            Destroy(other.gameObject);
            
            
        }
        
        
        
        

    }
}