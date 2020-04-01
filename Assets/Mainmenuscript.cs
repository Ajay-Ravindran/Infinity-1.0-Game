using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenuscript : MonoBehaviour {

	// Use this for initialization
	public void playGame1()
	{
		SceneManager.LoadScene(1);

	}
	public void playGame2()
	{
		SceneManager.LoadScene(2);

	}
	public void playGame3()
	{
		SceneManager.LoadScene(3);

	}
	public void playGame4()
	{
		SceneManager.LoadScene(4);

	}
	public void playGame5()
	{
		SceneManager.LoadScene(5);

	}
	public void playGame6()
	{
		SceneManager.LoadScene(6);

	}

	public void quitGame()
	{
		Debug.Log("quit");
		Application.Quit();
	}
}

