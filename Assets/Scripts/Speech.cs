using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speech : MonoBehaviour
{
	public GameObject speech;


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			speech.SetActive(true);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player")
		{
			speech.SetActive(false);
		}
	}
}
