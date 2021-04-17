using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camp : MonoBehaviour
{
    //public static SceneManagement.Scene GetSceneBuildIndex (int buildindex);
    public void OnTriggerEnter (Collider other)
    {

        if (GetComponent<Collider>().name == "FPSController") ;
        {
            SceneManager.LoadScene(2);
        }
    }
}