using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	public Transform targetA;
	public Transform targetB;

	bool targetIsA = true;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

    private void Start()
    {
		//transform.LookAt(targetA);
	}

    private void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			if (targetIsA)
			{
				//changeTarget to B
				FollowTarget(targetB);
				targetIsA = false;
			}
			else
			{
				//changeTarget to A
				FollowTarget(targetA);
				targetIsA = true;
			}
		}
	}

    void FixedUpdate()
	{
		
	}

	private void FollowTarget(Transform target)
    {
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;

		transform.LookAt(target);
	}
}
