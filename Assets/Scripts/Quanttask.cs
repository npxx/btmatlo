using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Quanttask : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    List<GameObject> bitss;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(bitss[0].GetComponent<TMP_Text>().text);
        string t1 = bitss[0].GetComponent<TMP_Text>().text;
        string t2 = bitss[1].GetComponent<TMP_Text>().text;
        string t3 = bitss[2].GetComponent<TMP_Text>().text;
        string t4 = bitss[3].GetComponent<TMP_Text>().text;
        string t5 = bitss[4].GetComponent<TMP_Text>().text;
        string t6 = bitss[5].GetComponent<TMP_Text>().text;
        string t7 = bitss[6].GetComponent<TMP_Text>().text;
        string t8 = bitss[7].GetComponent<TMP_Text>().text;
      

        if ((t3 == t7) && (t7 == t8) && (t8 == "0") && (t1 == t2) && (t2 == t4) && (t4 == t5) && (t5 == t6) && (t6 == "1"))
        {
            Debug.Log("okayy");
            Task.setTask1();
        }
        else
        {
            Debug.Log("bruh");
        }
    }

    public void click()
    {
        Debug.Log("clickho");
        TMP_Text a = transform.GetComponentInChildren<TMP_Text>();
        Debug.Log(a);
        if(a.text == "1") a.text = "0";
        else a.text = "1";
    }
}
