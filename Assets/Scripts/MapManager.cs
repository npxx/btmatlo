using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
   public void library()
   {
        SceneManager.LoadScene(3);
   }

    public void ncl()
   {
        SceneManager.LoadScene(4);
   }

    public void showmap()
    {
        SceneManager.LoadScene(2);
    }

}
