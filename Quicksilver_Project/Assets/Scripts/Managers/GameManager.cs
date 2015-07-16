using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class GameManager : MonoBehaviour 
{

	public GameObject pauseMenuPanel;
	public GameObject resultsScreen;
	
	public bool gamePaused = false;

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
		Cursor.lockState = CursorLockMode.Confined;
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

	public void ReturnToMainMenu ()
	{
		//EventSystem.current.SetSelectedGameObject(GameObject.Find ("ExitToMainMenu"));
		ResumeGame ();
		StartCoroutine(ChangeLevel(0));
	}

	public void RestartLevel ()
	{
		//EventSystem.current.SetSelectedGameObject(GameObject.Find ("Restart"));
		ResumeGame ();
		StartCoroutine(ChangeLevel(1));
	}

	public void OpenSuccessScreen ()
	{
		resultsScreen.SetActive (true);
		PauseGame();
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = true;
		EventSystem.current.SetSelectedGameObject(GameObject.Find ("Results_Restart"));
	}

	public IEnumerator ChangeLevel (int index)
	{
		Debug.Log("fading");
		float fadetime = this.GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds(fadetime);
		Application.LoadLevel(index);
	}
}
