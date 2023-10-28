using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class StartScreenManager : MonoBehaviour
{
    public static string naam, roll;
    public GameObject na, ro;
   public void MainMenu()
   {
    naam = na.GetComponent<TMP_Text>().text.ToString();
    roll = ro.GetComponent<TMP_Text>().text.ToString();
    SceneManager.LoadScene(1);
   }
       

        
}


