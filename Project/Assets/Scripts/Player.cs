using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public float rotate = 3;
    public string horizontalAxis, verticalAxis;
    // Start is called before the first frame update
    public GameObject deadCanvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis(verticalAxis);
        float y = Input.GetAxis(horizontalAxis);
        transform.Translate(0, speed * x, 0);
        transform.Rotate(0, 0, -y * rotate); //^^^ All Control the Movement of the Player
    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {
        //if (enemy.tag == "Enemy")
        //{
            deadCanvas.SetActive(true);
            Debug.Log("ENEMY");
        //}
    }
}
