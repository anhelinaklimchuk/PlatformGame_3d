using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemageController : MonoBehaviour
{
    public void OnTriggerEnter(Collider node)
       {
           if (node.gameObject.tag == "Player")
           {
               Destroy(node.gameObject);
           }
       }
}
