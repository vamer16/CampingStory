using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Characters.FirstPerson
{
    public class Forest : MonoBehaviour
    {
        public void OnTriggerEnter (Collider collider)
        {
            if (collider.name == "FPSController" && GamCC.instance.count >= 5)
            {
                //collider.GetComponent<FirstPersonController>().count++;
                //Debug.LogError("count"+ GamCC.instance.count);
                SceneManager.LoadScene(3);
            }
        }
    }
}