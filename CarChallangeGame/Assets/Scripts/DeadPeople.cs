using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadPeople : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "People")
        {
            
        }
    }
}
