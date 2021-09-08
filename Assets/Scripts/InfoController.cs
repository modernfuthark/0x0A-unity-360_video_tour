using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

///<summary>
/// InfoBox controller
///</summary>
public class InfoController : MonoBehaviour
{
	// InfoBox component
	private GameObject infoBox;

	///<summary>
	/// Fade animator
	///</summary>
	public Animation fadeAnimator;


	// Unity starter function
	void Start()
	{
		infoBox = gameObject.transform.GetChild(0).gameObject;
	}

	///<summary>
	/// Google XR PointerEnter function
	///</summary>
	public void OnPointerEnter()
	{
		gameObject.GetComponent<RectTransform>().sizeDelta += new Vector2(5, 5);
	}

	///<summary>
	/// Google XR PointerExit function
	///</summary>
	public void OnPointerExit()
	{
		gameObject.GetComponent<RectTransform>().sizeDelta -= new Vector2(5, 5);
	}

	///<summary>
	/// Google XR PointerClick function
	///</summary>
	public void OnPointerClick()
	{
        infoBox.gameObject.SetActive(!infoBox.gameObject.activeSelf);
	}

	// Disable button function, tied to a Unity button event
	void DisableButton(string n)
	{
		infoBox.gameObject.SetActive(false);
	}
}
