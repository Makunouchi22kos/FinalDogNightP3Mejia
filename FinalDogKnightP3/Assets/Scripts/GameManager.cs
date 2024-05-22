using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting.Antlr3.Runtime;

public class GameManager : MonoBehaviour
{

    public bool isGameActive; 
    public GameObject titleScreen;
    public GameObject button;

    public GameObject pauseScreen;
    private bool paused;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ChangePaused();
        }
    }


    // Game Start.
    public void StartGame()
    {
        isGameActive = true;

        titleScreen.gameObject.SetActive(false);
        button.gameObject.SetActive(false);
    }


    // Pause screen.
    void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
