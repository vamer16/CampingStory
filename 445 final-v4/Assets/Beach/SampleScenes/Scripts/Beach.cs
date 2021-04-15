using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.FirstPerson
{    
    public class Beach : MonoBehaviour
    {
        public void OnTriggerEnter (Collider collider)
        {
            if (collider.name == "FPSController" && GamCC.instance.count >= 6)
            //{
            //    LoadScene(2)
            //}
            SceneManager.LoadScene(1);
        }
    }
}