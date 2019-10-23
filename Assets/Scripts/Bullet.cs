﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public string sender;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(sender == "Player" && other.name.Contains("NPC Log"))
		{
			other.GetComponent<LogMovement>().hit(10);
			Destroy(gameObject);
		}
		else if(sender == "Log" && other.name.Contains("Player"))
		{
			other.GetComponent<PlayerMovement>().hit(10);
			Destroy(gameObject);
		}
		else if(other.name.Contains("Bullet"))
		{
			Destroy(gameObject);
		}
	}
}