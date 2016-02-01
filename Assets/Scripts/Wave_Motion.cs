using UnityEngine;
using System.Collections;

public class Wave_Motion : MonoBehaviour {

	private Vector3 startPos;
	float largeRange = 10.0f;
	float smallRange = 3.0f;
	float timer = 0.0f;
	float currRange = 3.0f;
	bool changeRange = true;
	float newRange = 1.0f;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}

	// Update is called once per frame
	void Update () {
		timer += (Time.deltaTime * 1.0f) % (2.0f + Mathf.PI);
		transform.position = startPos + new Vector3 (0.0f, Mathf.Sin (timer * 1.5f) * currRange, 0.0f);
		if (changeRange) {
			currRange = Mathf.MoveTowards (currRange, largeRange, Time.deltaTime + newRange);
			Debug.Log (changeRange);
		} else {
			currRange = Mathf.MoveTowards (currRange, smallRange, Time.deltaTime + newRange);
			Debug.Log (changeRange);
		}

		if (Input.GetKey (KeyCode.T)) {
			changeRange = !changeRange;
		}
	}
		
}
