using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;//全局变量
    public int index = 0;//拾取个数记录
    public Text berryTxt;//文件显示个数

    private void Awake()
    {
        _instance = this;//赋值全局变量
    }
    /// <summary>
    /// 跳转到游戏界面
    /// </summary>
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
}
