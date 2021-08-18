using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIP : MonoBehaviour
{
    public GameObject imageWIP;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			imageWIP.SetActive(true);
		}
	}
}
