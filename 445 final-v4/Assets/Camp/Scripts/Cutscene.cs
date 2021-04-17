using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    //public static SceneManagement.Scene GetSceneBuildIndex (int buildindex);
    public void OnTriggerEnter(Collider other)
    {
        //print("Hi");
        if (GetComponent<Collider>().name == "FPSController") ;
        {
            SceneManager.LoadScene(0);
        }
    }
}