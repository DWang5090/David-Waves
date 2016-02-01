using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float speed = 1.0f;

	private Vector3 lastMouse = new Vector3 (255,255,255);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 dir = new Vector3 ();

		if (Input.GetKey (KeyCode.W)) {
			dir.y += 0.1f;
		}

		if (Input.GetKey (KeyCode.S)) {
			dir.y -= 0.1f;
		}

		if (Input.GetKey (KeyCode.A)) {
			dir.x -= 0.1f;
		}

		if (Input.GetKey (KeyCode.D)) {
			dir.x += 0.1f;
		}


		if (Input.GetKey (KeyCode.UpArrow)){ 
			dir.z += 0.1f;
		}

		if (Input.GetKey (KeyCode.DownArrow)){ 
			dir.z -= 0.1f;
		}

		if (Input.GetKey (KeyCode.LeftArrow)){ 
			Vector3 rotate_cam = new Vector3 (0, Input.GetAxis ("Horizontal"), 0);
			transform.Rotate (rotate_cam * speed * Time.deltaTime); 
		}

		if (Input.GetKey (KeyCode.RightArrow)){ 
			Vector3 rotate_cam = new Vector3 (0, Input.GetAxis ("Horizontal"), 0);
			transform.Rotate (rotate_cam * speed * Time.deltaTime); 
		}

		transform.Translate (dir * speed * Time.deltaTime);
	}
}
