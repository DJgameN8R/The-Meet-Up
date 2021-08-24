using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bean_LookAtPlayer : MonoBehaviour
{
    public Transform player;
    public Transform startLook;
    
   

    bool playerEnter;
    bool StartLook;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerEnter = true;
            StartLook = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerEnter = false;
            StartLook = true;
        }
    }

    void Update()
    {
        if (playerEnter)
        {
            transform.LookAt(player);
        }
        if (StartLook)
        {
            transform.LookAt(startLook);
        }
    }
}
