using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public musicaudio;
    public AudioSource;
    public coinclip;
    public Background;
    public win;

    // Start is called before the first frame update
    void Start()
    {
        musicaudio.clip = Background;
        musicaudio.play();
    }

}
