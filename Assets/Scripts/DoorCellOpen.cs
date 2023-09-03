using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject TheDoor;
	public AudioSource CreakSound;
	public GameObject ExtraCross;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 2) {
			ExtraCross.SetActive (true);
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}
		if (Input.GetButtonDown("Action")) {
			if (TheDistance <= 2) {
				this.GetComponent<BoxCollider>().enabled = false;
				ActionDisplay.SetActive(false);
				ActionText.SetActive(false);
				TheDoor.GetComponent<Animation> ().Play ("FirstDoorOpenAnim");
				CreakSound.Play ();
			}
		}
	}

	void OnMouseExit() {
		ExtraCross.SetActive (false);
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
