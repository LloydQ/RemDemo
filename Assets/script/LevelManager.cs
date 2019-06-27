﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    static public LevelManager lm;
    public Transform player;
    public GameObject enemy;
    public float rateTime = 2;
    float myTime;
	// Use this for initialization
	void Awake () {
        lm = this;
	}
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;
        if(myTime > rateTime){
            Vector2 r = Random.insideUnitCircle.normalized * 30;
            Instantiate(enemy, player.position + new Vector3(r.x, 0, r.y), Quaternion.Euler(new Vector3(0, Random.Range(0.0f, 360.0f), 0)));
            myTime -= rateTime;
        }
	}
}
