using UnityEngine;
using System.Collections;

public class BallAttack : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider coll){
        if(coll.tag == "Enemy"){
            coll.GetComponent<SlimeMove>().Hurt();
        }
    }
}
