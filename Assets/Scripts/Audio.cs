using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bg;
    public AudioSource chime;
    void Start()
    {
        bg.Play();
        DontDestroyOnLoad(bg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click()
    {
        chime.Play();
    }
}
