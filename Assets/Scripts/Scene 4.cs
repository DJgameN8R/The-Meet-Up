using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4 : MonoBehaviour
{
	public GameObject pressE;


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
				SceneManager.LoadScene(1);
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
