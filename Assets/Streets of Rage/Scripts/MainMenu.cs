using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
	public void LoadMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

	public void LoadDemoLevel()
	{
		SceneManager.LoadScene("Stage1");
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		SceneManager.LoadScene("GameOver");
	}

	public void ExitGame()
	{
		Application.Quit();
	}
}
