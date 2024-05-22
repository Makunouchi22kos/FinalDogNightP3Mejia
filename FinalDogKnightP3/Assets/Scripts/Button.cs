using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Start game button
    public void StartGame(int StartGame)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
