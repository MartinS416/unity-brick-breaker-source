using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

	public float Speed;
	public Vector2 Dir;

	// Use this for initialization
	void Start ()
	{
		Speed = 800f;
		Dir = new Vector3(0.32123f,-1);
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Rigidbody>().velocity = (Dir * Time.deltaTime * Speed);
		Dir *= getHits();
	}
	
	Vector2 getHits()
	{
		RaycastHit hit;
		if (Physics.Raycast(transform.position, new Vector2(Dir.x / Mathf.Abs(Dir.x), 0), out hit, transform.localScale.x))
		{
			if (hit.collider.tag.Equals("Block"))
			{
				GameObject.Find("Score").GetComponent<ScoreCounter>().UpdateScore(1);
				Destroy(hit.collider.gameObject);
			}
			return new Vector2(-1, 1);
		}else if (Physics.Raycast(transform.position, new Vector2(0, Dir.y / Mathf.Abs(Dir.y)), out hit, transform.localScale.x))
		{
			if (hit.collider.tag.Equals("Block"))
			{
				GameObject.Find("Score").GetComponent<ScoreCounter>().UpdateScore(1);
				Destroy(hit.collider.gameObject);
			}
			return new Vector2(1, -1);
		}
		return new Vector2(1,1);
	}
}
