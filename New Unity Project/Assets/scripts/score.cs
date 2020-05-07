using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    Text txt;
    
    private int currentscore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "Score : " + currentscore;
    }

    //increase score with stomp virus
    // Update is called once per frame
    void Update()
    { 
        GameObject scoree = GameObject.FindWithTag("sto");
        stomp scoreR = scoree.GetComponent<stomp>();
        txt.text = "Score : " + scoreR.currentscore;
      
    }
}
