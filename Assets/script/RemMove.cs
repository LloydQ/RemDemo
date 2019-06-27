using UnityEngine;
using System.Collections;

public class RemMove : MonoBehaviour {
    public AnimationCurve ac;
    Vector3 s;
    public float speed = 6;
    public float rotspeed = 100;
	// Use this for initialization
	void Start () {
        s = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)){
            transform.Rotate(Vector3.up * Time.deltaTime * -rotspeed);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
        }
        float r = ac.Evaluate(Time.time);
        transform.localScale = new Vector3(s.x, s.y * r, s.z);
    }
}
