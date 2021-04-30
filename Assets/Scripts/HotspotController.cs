using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.Events;

public class HotspotController : MonoBehaviour
{
	public GameObject destination;
	public GameObject parent;

	public GameObject fadeSprite;
	public Animator animator;

    public GameObject InfoBoxes;

	void Start()
	{
		fadeSprite.GetComponent<Image>().rectTransform.localScale = new Vector2(Screen.width, Screen.height);
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
        //StartCoroutine(FadeToBlack());
        animator.SetTrigger("StartFade");
		destination.GetComponent<VideoPlayer>().Play();
		parent.GetComponent<VideoPlayer>().Stop();

		GameObject.Find("Player").transform.position = destination.gameObject.transform.position;

        foreach (Transform child in InfoBoxes.transform)
        {
            child.GetChild(0).gameObject.SetActive(false);
        }
	}
}
