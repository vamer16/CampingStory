using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishClick : MonoBehaviour
{

    [SerializeField] public GameObject textfish; 
    void Start()
    {
        textfish.SetActive(false);
    }
    
    
    void OnMouseDown()
    {
//        GetComponent<BoxCollider>().enabled = false;
//        GetComponent<Rigidbody>().useGravity = false;
//        this.transform.position = theDest.position;
//        this.transform.parent = GameObject.Find("Destination").transform;
    }
    
    void OnMouseUp()
    {
//        this.transform.parent = null;
//        GetComponent<Rigidbody>().useGravity = true;
//        this.GetComponent<Rigidbody>().AddForce(transform.position + Camera.main.transform.forward);
//        GetComponent<BoxCollider>().enabled = true;
        
        
        StartCoroutine(WaitForABit());
        
    }
    
    IEnumerator WaitForABit()
    {
        textfish.SetActive(true);
        yield return new WaitForSeconds(3);
        textfish.SetActive(false);
    }
}

