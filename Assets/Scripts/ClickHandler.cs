using UnityEngine;
using System.Collections;

public class ClickHandler : MonoBehaviour {
	
	public bool isAlien = false;
	// Use this for initialization
	void Start () {
		//EventManager.instance.AddListener(this, "Oso_clicked");
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnMouseDown() {
		if (isAlien) {
			// Ganamo
			Debug.Log("Ganaste!");
		}
		else {
			// Perdimo
			Debug.Log("Perdiste!");
		}
	}

}