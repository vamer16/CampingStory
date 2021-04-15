using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
public class Clam_Destroy : MonoBehaviour
    {
        void OnTriggerEnter(Collider collider)
        {
            if (collider.name == "FPSController");
            {
            collider.gameObject.GetComponent<FirstPersonController>().count++;
            GamCC.instance.Addsc();
            Destroy(this.gameObject);
            }
        }

    }
}