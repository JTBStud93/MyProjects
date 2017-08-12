using UnityEngine;
using System.Collections;

public class move3D : MonoBehaviour {
	public float moveSpeed;
	public float turnSpeed;
	public float jumpHeight;



	void Update() {
		var j = Input.GetAxis("Jump")* Time.deltaTime * jumpHeight;
		var y = Input.GetAxis("Horizontal")* Time.deltaTime * turnSpeed;
		var z = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;

		transform.Rotate(0,y,0);
		transform.Translate(0,0,z);
		transform.Translate(0,j,0);
	}

	/*
	public float smoothing = 1f;
	public Transform target;
	
	void Start()
	{
		StartCoroutine(MyCoroutine(target));
	}

	IEnumerator MyCoroutine (Transform target)
	{
		while(Vector3.Distance(transform.position,target.position) > 0.05f)
		{
			transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
			
			yield return null;
		}

		print("Reached the target.");

		yield return new WaitForSeconds(3f);

		print("MyCoroutine is now finished.");
	}

	*/
}
