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
    public GameObject HealthBar;
    public bool isGameActive; 
    public GameObject titleScreen;
    public GameObject button;
    public GameObject Background;
    public GameObject Slider;
    public GameObject VolumeText;
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
        Background.gameObject.SetActive(false);
        Slider.gameObject.SetActive(false);
        VolumeText.gameObject.SetActive(false);
        
        if (isGameActive = true)
        {
            HealthBar.SetActive(true);
        }
        else
        {
            HealthBar.SetActive(false);
        }
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
