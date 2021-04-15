using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlController : MonoBehaviour
{
    private AudioSource owlSound;//猫头鹰音效

    private void Start()
    {
        owlSound = GetComponent<AudioSource>();//赋值
    }
    /// <summary>
    /// 碰撞到主角之后，播放音效
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            owlSound.Play();
        }
    }
    /// <summary>
    /// 主角离开碰撞区域，音效暂停
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            owlSound.Pause();
        }
    }
}
