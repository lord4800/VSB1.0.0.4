using UnityEngine;
using System.Collections;

public class detectedScr : MonoBehaviour {
	Ray r;
	float f;

	// Use this for initialihation
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(0,1,0);
		//create forvard vector
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
		Vector3 vector;
		for (float h = -45.0f; h< 45.0f;h +=0.1f)
		{
			RaycastHit[] hitsh;
			vector = Quaternion.AngleAxis(h, Vector3.up) * forward;
			Debug.DrawRay(transform.position, vector, Color.green);
			hitsh = Physics.RaycastAll(transform.position, vector, 10.0F);//right
			//Debug.DrawRay(transform.position, forward + new Vector3(h, 0, 0), Color.blue);
			for (int i = 0; i < hitsh.Length; i++)
			{
				RaycastHit hit = hitsh[i];

				Renderer rend = hit.transform.GetComponent<Renderer>();
				if (rend) 
				{
					// Change the material of all hit colliders
					// to use a transparent shader.
					rend.material.shader = Shader.Find("Transparent/Diffuse");
					Color tempColor = rend.material.color;
					tempColor.a = 0.3F;
					rend.material.color = tempColor;
				}
			}
		}
		/*for (float h = -10.0f; h< 10.0f;h +=0.1f)
		{
			RaycastHit[] hitsh;
			vector = Quaternion.AngleAxis(-45, Vector3.up) * forward;
			Debug.DrawRay(transform.position, vector, Color.green);
			vector = Quaternion.AngleAxis(+45, Vector3.up) * forward;
			Debug.DrawRay(transform.position, vector, Color.green);
			hitsh = Physics.RaycastAll(transform.position, forward + new Vector3(h , 0, 0), 10.0F);//right
			//Debug.DrawRay(transform.position, forward + new Vector3(h, 0, 0), Color.blue);
			for (int i = 0; i < hitsh.Length; i++)
			{
				RaycastHit hit = hitsh[i];

				Renderer rend = hit.transform.GetComponent<Renderer>();
				if (rend) 
				{
					// Change the material of all hit colliders
					// to use a transparent shader.
					rend.material.shader = Shader.Find("Transparent/Diffuse");
					Color tempColor = rend.material.color;
					tempColor.a = 0.3F;
					rend.material.color = tempColor;
				}
			}

		}
		*/
		Debug.DrawRay(transform.position, forward, Color.green);
		RaycastHit hit1;
		Ray ray = new Ray(transform.position, forward);
		if (Physics.Raycast(ray, out hit1))
		{
			if (hit1.collider != null)
			{
				Debug.Log("Find something");
			}
		}
	}
}
