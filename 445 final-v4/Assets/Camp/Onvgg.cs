using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onvgg : MonoBehaviour
{
    public void OnMouseDown()
    {
        GamCC.instance.Addsc();
        Destroy(this.gameObject);
    }
}
