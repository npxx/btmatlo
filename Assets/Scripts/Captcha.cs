using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Captcha : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField capp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkk()
    {
        Debug.Log(capp.text);
        int val = int.Parse(capp.text);
        Debug.Log(val);
        if (val == 31415926)
        {
            Debug.Log("cool");
            Task.setTask2();
        }

    }
}
