using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject deadCanvas;
    public bool enterZone;
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
            Debug.Log("ENEMY");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {

        if (enemy.tag == "Enemy")
        {
            enterZone = enabled;

        }
    }
}
