using UnityEngine;
using System.Collections;

public class Introstart : MonoBehaviour 
{
	public GameObject g;
	public float tm;

	void Start()
	{
		StartCoroutine (startDelay ());
	}

	IEnumerator startDelay()
	{
		yield return new WaitForSeconds (tm);
		g.SetActive (true);
	}
}