using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public GameObject ipanel;

    // Start is called before the first frame update
    void Start()
    {
        ipanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ipanel.SetActive(false);
        }
    }

    public void play()
    {
        // Load the main game scene (assuming it's at build index 2)
        SceneManager.LoadScene(2);

    }

     public void instructions()
    {
        // Show the instructions panel
        ipanel.SetActive(true);
    }

    public void quit()
    {
        // Quit the game (only works in standalone builds)
        Application.Quit();
    }
}
