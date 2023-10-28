using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public static float timeRemaining = 180f;
    public static bool timerIsRunning = false;
    public TMP_Text timm;
    public static GameObject timerr;

    private void Awake()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
            timerIsRunning = true;

    }
    void Start()
    {
        // Starts the timer automatically
    }
    void Update()
    {
        //Debug.Log(StartScreenManager.naam);

        //Debug.Log(timeRemaining);
        int minn = (int) Mathf.Floor(timeRemaining / 60f);
        int sec = (int) Mathf.Floor(timeRemaining - minn * 60f);
        timm.text = minn.ToString() + " :" + sec.ToString();
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                SceneManager.LoadScene(5);
            }
        }
    }
}


