using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
    public AnimationCurve ac;
    Vector3 s;
    // Use this for initialization
    void Start () {
        s = transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
        float r = ac.Evaluate(Time.time);
        transform.localScale = new Vector3(s.x, s.y * r, s.z);
    }
}
