using UnityEngine;
using System.Collections;

public class creditsScroll : MonoBehaviour {

	bool crawling = true;
	RectTransform rt;
	
	// Use this for initialization
	void Start () {
		rt = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!crawling)
			return;
		rt.Translate(Vector3.down * Time.deltaTime*20);
		/*
		if (gameObject.transform.position.y > .8)
		{
			crawling = false;
		}
		*/
	}
}
