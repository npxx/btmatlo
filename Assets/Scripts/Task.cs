using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    public static bool task1 = false, task2 = false;
    public static void setTask1()
    {
        task1 = true;
    }

    public static void setTask2()
    {
        task2 = true;
    }

    [SerializeField]
    Sprite high, low;

    [SerializeField]
    SpriteRenderer taskren;

    [SerializeField]
    GameObject taskk;
    void Start()
    {
    }

    void Update()
    {
        if((SceneManager.GetActiveScene().buildIndex == 3))
        {
            if (task1 == false)
            {
                taskren.gameObject.SetActive(true);
            }
            else
            {
                 taskren.gameObject.SetActive(false);
            }
        }

        if ((SceneManager.GetActiveScene().buildIndex == 4))
        {
            if (task2 == false)
            {
                taskren.gameObject.SetActive(true);
            }
            else
            {
                taskren.gameObject.SetActive(false);
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        taskren.sprite = high;
        Debug.Log("collidee");
        Invoke("tasktog", 1f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        taskren.sprite = low;
        Debug.Log("exx");
        Invoke("tasktog", 1f);
    }

    public void tasktog()
    { taskk.SetActive(!taskk.activeSelf); }
}
