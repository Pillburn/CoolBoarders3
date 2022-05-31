using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.ParticleSystemJobs;

public class FinishLine : MonoBehaviour
{
        public float delay = 1.0f;
        public ParticleSystem finishworks;
    // Update is called once per frame

        void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.tag == "Player"){
                finishworks.Play();
                Invoke("ReloadScene",delay);
            }
        }

        void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    
}
