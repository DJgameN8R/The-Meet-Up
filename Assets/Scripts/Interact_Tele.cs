using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_Tele : MonoBehaviour
{
	public GameObject pressE;
	public GameObject teleportObject;
	public GameObject teleportLocation;

	private bool inTrigger;

	void Start()
	{


	}

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (inTrigger == true)
			{
				teleportObject.transform.position = teleportLocation.transform.position;
			}
		}
	}


    void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Player")
		{
			pressE.SetActive(true);
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player")
			inTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		inTrigger = false;
		pressE.SetActive(false);
	}
}
