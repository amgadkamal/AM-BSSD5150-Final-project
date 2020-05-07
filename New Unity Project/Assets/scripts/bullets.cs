using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullets : MonoBehaviour
{
    
    private int speed = 3;
    public int NoOfenemies = 0;
    public int currentscore = 7;
    public int updatescore = 0;
    void Start()
    { GetComponent<Rigidbody2D>().velocity = transform.right * speed; }

    //bullets not effected by each other
    void OnEnable() {
        GameObject[] otherObjects = GameObject.FindGameObjectsWithTag("bullets");

        foreach (GameObject obj in otherObjects) {
            Physics2D.IgnoreCollision(obj.GetComponent<Collider2D>(), GetComponent<Collider2D>()); 
        }
        
    }

//kill robot enemies with bullets
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {  
           
            Debug.Log("buulet script"+updatescore);
            Destroy(other.gameObject); } }
    
    
   public void Update()
    
    {
        Debug.Log(NoOfenemies);
        GameObject scoreObj = GameObject.Find("ScoreObject");
        ScoreController scoreC = scoreObj.GetComponent<ScoreController>();
        scoreC.score = currentscore;

        
    }

   
}
