using UnityEngine;
using System.Collections;

public class ControllerCam: MonoBehaviour 
{
	/*public Rect Rectangle1
	{
		get;
		private set;
	}*/
	public GameObject player; //Переменна объекта персонажа с которым будем работать. 
	//public Texture2D player;
	//public ch
	void Start () 
	{ 
		
	} 
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.position = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);

	}
	/*void OnGUI()
	{
		GUI.DrawTexture(Rectangle, player);
	}*/
}
