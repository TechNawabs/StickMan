using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour 
{
	public float tym;
	public GameObject go,bk,bg;

	void Start () 
	{
		
		StartCoroutine ("TitleGeneration");
		StartCoroutine ("LaunchBook");
	}
		
	IEnumerator TitleGeneration()
	{
		yield return new WaitForSeconds (tym);
		go.SetActive (true);
	}

	IEnumerator LaunchBook()
	{
		yield return new WaitForSeconds (12f);
		Destroy (go);
		bk.SetActive (true);
		bg.SetActive (true);
	}
}