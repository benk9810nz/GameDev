using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Wall : MonoBehaviour
{
    public Text HealthStatus;
    public bool enterZone;
    public Player player;
    public GameObject deadCanvas;
    public float dmgTick = 1;
    public AudioClip clip;
    public AudioClip carengine;
    public AudioSource source;

    public void Update()
    {
        if (player.health == 0)
        {
            deadCanvas.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.name == "Player")
        {
            if (!enterZone)
            {
                source.clip = clip;
                source.Play();  
                player.health--;
                Invoke("DamagePlayer", dmgTick);
            }
            else

            enterZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D enemy)
    {
        if (enemy.name == "Player")
        {
            source.clip = carengine;
            source.Play();
            enterZone = false;
        }
    }

    void DamagePlayer()
    {
        player.health--;
        HealthStatus.text = string.Format("{0}", player.health);
        if (enterZone)
        {
            Invoke("DamagePlayer", dmgTick);
        }
    }
}
