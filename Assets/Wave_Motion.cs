using UnityEngine;
using System.Collections;

public class Wave_Motion : MonoBehaviour {

	private Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.position = startPos + new Vector3(0.0f, Mathf.Sin(Time.time * 1.5f) * 3.0f, 0.0f);
		Vector2 v2 = new Vector2 (-4.5f, 0.0f) + (new Vector2 (12.0f, 8.0f) * 1.0f/60.0f);
		Debug.Log (v2);
	}
}
