using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Enemy : MonoBehaviour
{
	float Speed = 3f;

	private GameObject wayPoint;
	private Vector3 wayPointPos;

	 
	void Start()
    {
		wayPoint = GameObject.Find("wayPoint");
		
	
	}
	void Update()
	{
		
		wayPointPos = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);

		transform.rotation = Quaternion.LookRotation(Vector3.forward, wayPointPos - transform.position);
		transform.position = Vector3.MoveTowards(transform.position, wayPointPos, Speed * Time.deltaTime);

		if(transform.position == wayPointPos)
        {
			
			SceneManager.LoadScene("GameOverZS");
		}
		

	}
	public void SetMoveSpeed(float speed)
	{
		Speed = speed;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Destroy(collision);
		Destroy(gameObject);
		



	}

}
