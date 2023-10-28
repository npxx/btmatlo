using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TMP_Text name, roll, task1, task2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        name.text = StartScreenManager.naam;
        roll.text = StartScreenManager.roll;
        if (Task.task1 == true)
        {
            task1.text = "S";
        }
        else task1.text = "X";

        if (Task.task2 == true)
        {
            task2.text = "S";
        }
        else task2.text = "X";

    }

    public void showRes()
    {
        SceneManager.LoadScene(5);
    }
}
