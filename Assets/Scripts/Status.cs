using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Status : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator popp;
    public TMP_Text t1d, t2d;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Task.task1)
        {
            t1d.text = "Yay!";
        }
        else t1d.text = "DO IT!";

        if (Task.task2)
        {
            t2d.text = "Yay!";
        }
        else t2d.text = "DO IT!";
    }

    public void open()
    {
        popp.SetBool("open", !popp.GetBool("open"));
        popp.SetBool("close", !popp.GetBool("close"));

    }

    public void close()
    {
        popp.SetBool("close", true);
        popp.SetBool("open", false);

    }

}
