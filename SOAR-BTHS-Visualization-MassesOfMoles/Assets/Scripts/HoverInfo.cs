using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverInfo : MonoBehaviour {

	public GameObject itemInfo1, itemInfo2, itemInfo3;
	public bool selected = false;

	public void toggleSelected() {

		selected = !selected;

		if (selected) {
			itemInfo1.SetActive (false);
			itemInfo2.SetActive (false);
			itemInfo3.SetActive (false);
		}
	}
		
	public void enableInfo() {
		if (!selected) {
			itemInfo1.SetActive (true);
			itemInfo2.SetActive (true);
			itemInfo3.SetActive (true);

		}
	}

	public void disableInfo() {
		if (!selected) {
			itemInfo1.SetActive (false);
			itemInfo2.SetActive (false);
			itemInfo3.SetActive (false);

		}
	}
}
