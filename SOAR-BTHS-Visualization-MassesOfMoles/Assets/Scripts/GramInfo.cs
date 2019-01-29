using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GramInfo : MonoBehaviour {

	public Text gramText;
	public GameObject gramSelectedFill, gramDescription, GramToMole, MoleToGram;
	public GameObject gramArrow;
	public bool selected = false;

	public void toggleInfo() {

		selected = !selected;

		if (selected) {
			gramText.color= new Color(1.0f,1.0f,1.0f,1.0f);
			gramSelectedFill.SetActive(true);
			gramDescription.SetActive(true);
			GramToMole.SetActive(true);
			MoleToGram.SetActive(true);
			gramArrow.SetActive(true);
		} else {
			gramText.color = new Color (0.11f, 0.19f, 0.2f, 1.0f);
			gramSelectedFill.SetActive (false);
			gramDescription.SetActive(false);
			GramToMole.SetActive(false);
			MoleToGram.SetActive(false);
			gramArrow.SetActive (false);
		}
	}
}
