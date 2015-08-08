using UnityEngine;
using System.Collections;

public class CameraContoller : MonoBehaviour 
{


	public GameObject player;
	
	private Vector3 offset;
	
	void Start ()
	{
		offset = transform.position - player.transform.position;
	}
	
	void Update ()
	{
		
		Vector3 mausRotation = new Vector3 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0);
		Quaternion rotation = Quaternion.LookRotation(mausRotation);
		
		if (Input.GetMouseButtonDown(1))
			transform.rotation = rotation;
	}

	void LateUpdate ()
	{
		//Vector3 startPos = new Vector3 (194, 7, 221);
		//Vector3 relativePos = startPos - transform.position;


		transform.position = player.transform.position + offset;
	}
}
