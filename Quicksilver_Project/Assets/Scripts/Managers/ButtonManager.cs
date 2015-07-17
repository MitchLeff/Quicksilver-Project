using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonManager : MonoBehaviour, IPointerEnterHandler, ISelectHandler, IDeselectHandler
{
	private Animator anim;

	// Use this for initialization
	void Start () 
	{
		anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (EventSystem.current.currentSelectedGameObject != this.gameObject && anim.enabled && !anim.GetCurrentAnimatorStateInfo(0).IsName("Normal"))
			anim.SetTrigger("Normal");
	}

	public void OnPointerEnter (PointerEventData eventData)
	{
		EventSystem.current.SetSelectedGameObject(this.gameObject);
	}
	
	public void OnDeselect (BaseEventData eventData)
	{
		anim.SetTrigger("Normal");
	}	

	public void OnSelect (BaseEventData eventData)
	{
		anim.SetTrigger("Highlighting");
		anim.SetTrigger("SelectionTrigger");
	}
}
