using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public float rotate = 3;
    public string horizontalAxis, verticalAxis;
    public float health = 20;
    // Start is called before the first frame update
    public GameObject deadCanvas;
    public AudioClip engineFX;
    public AudioSource src;
    public AudioClip explosion;
    public AudioClip reverse;

    void Start()
    {
        src.clip = engineFX;
        src.Play();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis(verticalAxis);
        float y = Input.GetAxis(horizontalAxis);
        transform.Translate(0, speed * x, 0);
        transform.Rotate(0, 0, -y * rotate); //^^^ All Control the Movement of the Player  
        
        if (health <= 0f)
        {
            deadCanvas.SetActive(true);
            src.clip = explosion;
            src.Play();
//            Time.timeScale = 0f;
        }
    }
}