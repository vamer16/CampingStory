using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
//I connected my audio source and volume slider to the game through this script
{
   public  AudioSource BGMusic;
   public float AudioVolume = 1f;
   public Slider volcontrol;
    
    //commented bottom line out as i didnt need it
    void Start()
    {
        //AudioSource = GetComponent<BGMusic>();
    }

    void Update()
    {
        BGMusic.volume = AudioVolume;
    }
//used the setvolume function for my slider
    public void SetVolume()
    {
        AudioVolume = volcontrol.value;
    }
}
