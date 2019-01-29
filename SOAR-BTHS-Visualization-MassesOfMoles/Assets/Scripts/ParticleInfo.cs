using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParticleInfo : MonoBehaviour {

	public Text particleText;
	public GameObject particleSelectedFill, particleDescription, ParticleToMole, MoleToParticle;
	public GameObject particleArrow;
	public bool selected = false;

	public void toggleInfo() {

		selected = !selected;

		if (selected) {
			particleText.color = new Color (1.0f, 1.0f, 1.0f, 1.0f);
			particleSelectedFill.SetActive (true);
			particleDescription.SetActive (true);
			ParticleToMole.SetActive (true);
			MoleToParticle.SetActive (true);
			particleArrow.SetActive (true);
		} else {
			particleText.color = new Color (0.11f, 0.19f, 0.2f, 1.0f);
			particleSelectedFill.SetActive (false);
			particleDescription.SetActive(false);
			ParticleToMole.SetActive(false);
			MoleToParticle.SetActive(false);
			particleArrow.SetActive (false);
		}
	}
}
