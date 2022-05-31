using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.ParticleSystemJobs;

public class CrashDetector : MonoBehaviour
{
    CircleCollider2D playerhead;

    public ParticleSystem ps;

    public float delay = 1.0f;

    void Start() 
    {
        playerhead = GetComponent<CircleCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D other) {

        if(other.gameObject.tag == "Ground" && playerhead.IsTouching(other.gameObject.GetComponent<Collider2D>()))
        {
            ps.Play();
            Invoke("ReloadScene",delay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
