using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour 
{
	public bool playClicked;

	public void OnClick()
	{
		StartCoroutine ("startIt");
		playClicked = true;
	}

	IEnumerator startIt()
	{
		yield return new WaitForSeconds (0.3f);
		SceneManager.LoadScene ("Level_1");
	}
		
}