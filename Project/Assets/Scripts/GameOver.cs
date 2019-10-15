using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string TitleScene;
    public string LevelScene;
    public bool isDead;
    public GameObject deadCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SelectTitle()
    {
        SceneManager.LoadSceneAsync(TitleScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
