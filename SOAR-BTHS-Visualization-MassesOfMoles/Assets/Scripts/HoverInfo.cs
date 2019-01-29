using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverInfo : MonoBehaviour {

	public GameObject itemInfo1, itemInfo2;

	public void enableInfo() {
		itemInfo1.SetActive(true);
		itemInfo2.SetActive(true);
	}

	public void disableInfo() {
		itemInfo1.SetActive(false);
		itemInfo2.SetActive(false);
	}
}
