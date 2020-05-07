using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    
    public AudioMixerSnapshot killvirus;
    public AudioSource killviruss;
    private float transitionTime = 1f;
    //if player hit virus transition will happen with music
        private void OnTriggerEnter2D(Collider2D collision)

        {
            if (collision.tag == "virus")
            {
                killvirus.TransitionTo(transitionTime);
                killviruss.Play();
            }
        }
        
      
    


}
