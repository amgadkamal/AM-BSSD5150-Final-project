using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public Text inputFieldCoo;
    public Text inputFieldCooo;
    public Text texto;
    string m_PlayerName;
    
        void Start()

        {
            //get the user name and view it at start
            GameObject textoo = GameObject.FindWithTag("view");
            texto= textoo.GetComponent<Text>();
            m_PlayerName = PlayerPrefs.GetString("Name", "No Name");
            texto.text=m_PlayerName;
            
            //two buttons one to start game and the other to submit user name
            GameObject.FindWithTag("start").GetComponent<Button>().onClick.AddListener(startgame);
            GameObject.FindWithTag("submit").GetComponent<Button>().onClick.AddListener(submittt);
        }
        
        public void Update()
        { 
            //input field and text
            GameObject inputFieldGo = GameObject.FindWithTag("input");
            InputField inputFieldCo = inputFieldGo.GetComponent<InputField>();
            
            GameObject inputFieldGoo = GameObject.FindWithTag("name");
            inputFieldCoo= inputFieldGoo.GetComponent<Text>();
            
         
            inputFieldCoo.text = inputFieldCo.text;
            PlayerPrefs.Save();
            Debug.Log(PlayerPrefs.GetString("Name"));
        }



        void startgame()
        {
            SceneManager.LoadScene("main");
        }
        
        void submittt()
        {
            PlayerPrefs.SetString("Name", inputFieldCoo.text);
            texto.text = m_PlayerName;
        }
    
}
