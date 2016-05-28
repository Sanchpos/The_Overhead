using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {

	CharacterMoveController cmc;
	// Use this for initialization
	void Start () {
		cmc = GetComponent<CharacterMoveController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (cmc.isGrounded() && cmc.getSpeed() > 0 && !GetComponent<AudioSource>().isPlaying) {
			GetComponent<AudioSource>().Play();
		}
	}
}
