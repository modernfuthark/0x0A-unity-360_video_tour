using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.Events;

///<summary>
/// Controls Hotspots
///</summary>
public class HotspotController : MonoBehaviour
{
	///<summary>
	/// Destination GameObject, used to teleport
	///</summary>
	public GameObject destination;
	///<summary>
	/// Parent GameObject, used to freeze previous video to avoid performance strain
	///</summary>
	public GameObject parent;

	///<summary>
	/// GameObject used to fade the screen
	///</summary>
	public GameObject fadeSprite;
	///<summary>
	/// Fade animator
	///</summary>
	public Animator animator;
	
	///<summary>
	/// Infoboxes GameObject
	///</summary>
	public GameObject InfoBoxes;


	//Unity starter function
	void Start()
	{
		fadeSprite.GetComponent<Image>().rectTransform.localScale = new Vector2(Screen.width, Screen.height);
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
		// Fade the screen
        	animator.SetTrigger("StartFade");
		destination.GetComponent<VideoPlayer>().Play();
		parent.GetComponent<VideoPlayer>().Stop();

		// Teleport the player gameobject to the destination
		GameObject.Find("Player").transform.position = destination.gameObject.transform.position;

		// Disable all infoboxes, in case the user keeps one open
        	foreach (Transform child in InfoBoxes.transform)
        	{
            	child.GetChild(0).gameObject.SetActive(false);
        	}
	}
}
