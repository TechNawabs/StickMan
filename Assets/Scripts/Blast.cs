using UnityEngine;
using System.Collections;

public class Blast : MonoBehaviour 
{
	public GameObject eff,c;
	public bool started;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "rocket") 
		{
			started = true;
			c.SetActive (true);
			Destroy (eff);
			Destroy (other.gameObject);
		}
	}
}