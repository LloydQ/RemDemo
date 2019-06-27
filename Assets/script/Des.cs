using UnityEngine;
using System.Collections;

public class Des : MonoBehaviour {
    public float lifeTime = 1;
    // Use this for initialization
    void Start(){
        Destroy (gameObject, lifeTime);
    }
}
