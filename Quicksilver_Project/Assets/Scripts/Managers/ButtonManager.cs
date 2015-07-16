using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonManager : MonoBehaviour, IPointerEnterHandler 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
//		if (EventSystem.current.currentSelectedGameObject != this.gameObject)
//			gameObject.GetComponent<Button>().
	}

	public void OnPointerEnter (PointerEventData eventData)
	{
		Debug.Log ("Mouse over button");
		EventSystem.current.SetSelectedGameObject(this.gameObject);
	}

}
