using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "Auto")
        {
            
            Debug.Log("ENTER");
        }
    }
    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.name == "Auto")
        {

            Debug.Log("STAY");
        }
    }
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "Auto")
        {

            Debug.Log("EXIT");
        }
    }
}