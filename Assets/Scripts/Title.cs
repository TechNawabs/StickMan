using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour 
{
	public float tym;
	public GameObject go,bk;

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
		Destroy(GameObject.Find("sparkles(Clone)"));
		bk.SetActive (true);
	}
}