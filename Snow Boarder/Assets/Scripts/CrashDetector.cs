using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTime = 2f;
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", reloadTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

