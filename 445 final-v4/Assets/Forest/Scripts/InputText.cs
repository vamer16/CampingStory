using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public Image dialog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool isCollider = Physics.Raycast(ray, out hit);

        if (isCollider)
        {
            //Debug.Log(hit.transform.tag);
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.tag == "ball")
                {
                    dialog.gameObject.SetActive(true);
                }
                else
                {
                    dialog.gameObject.SetActive(false);
                }
               
            }
           
        }       
    }
}
