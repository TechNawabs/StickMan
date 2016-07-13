using UnityEngine;
using System.Collections;

public class Blast : MonoBehaviour 
{
	public GameObject eff;
	public ParticleSystem ps;
	public bool started;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "rocket") 
		{
			Destroy (eff);
			Destroy (other.gameObject);
			Instantiate (ps);
			started = true;
		}
	}
}