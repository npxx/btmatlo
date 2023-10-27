using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Task : MonoBehaviour
{
    [SerializeField]
    Sprite high, low;

    [SerializeField]
    SpriteRenderer taskren;
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        taskren.sprite = high;
        Debug.Log("collidee");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        taskren.sprite = low;
        Debug.Log("exx");
    }
}
