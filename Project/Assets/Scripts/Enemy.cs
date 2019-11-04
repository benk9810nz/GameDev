using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject deadCanvas;
    public bool enterZone;
    public AudioClip clip;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enterZone)
        {
            deadCanvas.SetActive(true);
        }
        else
        {
            deadCanvas.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {

        if (enemy.name == "Player")
        {
            source.clip = clip;
            source.Play();
            enterZone = true;
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerExit2D(Collider2D enemy)
    {

        if (enemy.name == "Player")
        {
            enterZone = false;
            Time.timeScale = 1f;
        }
    }
}
