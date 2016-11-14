﻿using UnityEngine;
using System.Collections;

public class RifleController : MonoBehaviour {

	//public float attackCD = 0.3f; ---Rifle has no cooldown
	public int damage;
	public GameObject rightBullet;
	public GameObject leftBullet;

	private bool attacking = false;
	private float attackTimer = 0;

	private Transform firePoint;

	void Start()
	{
		firePoint = transform.FindChild("firePoint");
	}

	void Update()
	{
		/*
		if (Input.GetKeyDown (KeyCode.Space) && !attacking) 
		{
			attacking = true;
			attackTimer = attackCD;
		}

		if (attacking) 
		{
			if (attackTimer > 0) 
			{
				attackTimer -= Time.deltaTime;
			}
			else 
			{
				attacking = false;
			}
		}*/
	}

	public void attack()
	{
		//attacking = true;
		//attackTimer = attackCD;
		if (firePoint.transform.position.x > gameObject.transform.position.x) {
			Instantiate (rightBullet, firePoint.position, Quaternion.identity);
		}
		if (firePoint.transform.position.x < gameObject.transform.position.x) {
			Instantiate (leftBullet, firePoint.position, Quaternion.identity);
		}
	}
}
