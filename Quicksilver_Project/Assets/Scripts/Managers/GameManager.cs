using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class GameManager : MonoBehaviour 
{

	public GameObject pauseMenuPanel;
	
	private bool gamePaused = false;

	// Use this for initialization
	void Start () 
	{
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Start"))
		{
			if (!gamePaused)
			{
				PauseGame();
				if (pauseMenuPanel != null)
				{
					OpenPauseMenu();
				}
			}
			else if (gamePaused)
			{
				ResumeGame();
				if (pauseMenuPanel != null)
				{
					ClosePauseMenu();
				}
			}
		}
	
	}

	public void PauseGame ()
	{
		Time.timeScale = 0;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
		gamePaused = true;
	}

	public void ResumeGame ()
	{
		Time.timeScale = 1;
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = false;
		gamePaused = false;
	}

	public void OpenPauseMenu ()
	{
		pauseMenuPanel.SetActive (true);
		EventSystem.current.SetSelectedGameObject(GameObject.Find ("Resume"));
	}

	public void ClosePauseMenu ()
	{
		pauseMenuPanel.SetActive (false);
	}
}
