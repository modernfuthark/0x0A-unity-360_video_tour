using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class InfoController : MonoBehaviour
{
	private GameObject infoBox;

	public Animation fadeAnimator;

	public void Start()
	{
		infoBox = gameObject.transform.GetChild(0).gameObject;
	}

	public void OnPointerEnter()
	{
		gameObject.GetComponent<RectTransform>().sizeDelta += new Vector2(5, 5);
	}

	public void OnPointerExit()
	{
		gameObject.GetComponent<RectTransform>().sizeDelta -= new Vector2(5, 5);
	}

	public void OnPointerClick()
	{
        infoBox.gameObject.SetActive(!infoBox.gameObject.activeSelf);
	}

	void DisableButton(string n)
	{
		infoBox.gameObject.SetActive(false);
	}
}
