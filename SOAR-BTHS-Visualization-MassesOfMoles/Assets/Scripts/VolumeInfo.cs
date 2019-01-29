using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeInfo : MonoBehaviour {

	public Text volumeText;
	public GameObject volumeSelectedFill, volumeDescription, VolumeToMole, MoleToVolume;
	public GameObject volumeArrow;
	public bool selected = false;

	public void toggleInfo() {

		selected = !selected;

		if (selected) {
			volumeText.color= new Color(1.0f,1.0f,1.0f,1.0f);
			volumeSelectedFill.SetActive(true);
			volumeDescription.SetActive(true);
			VolumeToMole.SetActive(true);
			MoleToVolume.SetActive(true);
			volumeArrow.SetActive(true);
		} else {
			volumeText.color = new Color (0.11f, 0.19f, 0.2f, 1.0f);
			volumeSelectedFill.SetActive (false);
			volumeDescription.SetActive(false);
			VolumeToMole.SetActive(false);
			MoleToVolume.SetActive(false);
			volumeArrow.SetActive (false);
		}
	}
}
