using UnityEngine;
using System.Collections;

public class LinearMoveBehavior : MonoBehaviour {
	
	public float speed = 1;
	public Transform myTransform;
	// Use this for initialization
	void Start () {
		myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		this.myTransform.Translate(new Vector3(speed, 0, 0));
	}
}