using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    // Start is called before the first frame update
   //click to restart after lose
    void Start()
    {
        GameObject.FindWithTag("restart").GetComponent<Button>().onClick.AddListener(goBack);
    }

    void goBack()
    {
        SceneManager.LoadScene("start");
    }
    }

   
    

