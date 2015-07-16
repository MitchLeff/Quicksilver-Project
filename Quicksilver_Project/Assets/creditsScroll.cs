using UnityEngine;
using System.Collections;

public class creditsScroll : MonoBehaviour 
{

	bool crawling = true;
	RectTransform rt;
	private GameObject gm;

	// Use this for initialization
	void Start () 
	{
		rt = GetComponent<RectTransform> ();
		gm = GameObject.Find ("GameManager");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Start"))
		{
			gm.GetComponent<GameManager>().ResumeGame();
			StartCoroutine(gm.GetComponent<GameManager>().ChangeLevel(0));
		}

		if (!crawling)
		{
			StartCoroutine(gm.GetComponent<GameManager>().ChangeLevel(0));
		}
		else if (crawling)
		{
			rt.Translate(Vector3.down * Time.deltaTime*20);
			if (rt.anchoredPosition3D.y < -400)
			{
				crawling = false;
			}
		}
	}
}
