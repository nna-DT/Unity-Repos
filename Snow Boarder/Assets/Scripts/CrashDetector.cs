using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTime = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool hitHead = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !hitHead)
        {
            hitHead = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", reloadTime);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

