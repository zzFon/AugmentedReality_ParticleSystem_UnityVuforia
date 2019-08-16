using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetARCamera : MonoBehaviour 
{
	public Camera arcam;
	void Update () // AR_Camera is the world Center
	{              // in order to fit the fields,
		           // we have to configurate the rotation anad position of the Cam
		arcam.transform.position = new Vector3 (0.0f, 0.5f, 0.0f);
		arcam.transform.rotation = Quaternion.identity;
		arcam.transform.Rotate (new Vector3 (90, 0, 0));
	}
}
