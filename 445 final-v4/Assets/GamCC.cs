using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GamCC : MonoBehaviour
{

    public Text ccTxt;
    public static GamCC instance;

    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        count = 0;
    }

   public void Addsc()
    {
        count++;
        ccTxt.text = count.ToString();
    }
}
