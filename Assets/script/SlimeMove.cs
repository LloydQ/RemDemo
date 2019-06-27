using UnityEngine;
using System.Collections;

public class SlimeMove : MonoBehaviour {
    public AnimationCurve ac;
    Vector3 s;
    public Transform player;
    public float rotSpeed;
    public float Speed;
    public GameObject blood;
	// Use this for initialization
	void Start () {
        player = LevelManager.lm.player;
        s = transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 targetDir = player.position - transform.position;
        float step = rotSpeed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward , targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        float r = ac.Evaluate(Time.time);
        transform.localScale = new Vector3(s.x, s.y * r, s.z);
    }

    public void Hurt(){
        Destroy(gameObject);
        Instantiate(blood, transform.position, Quaternion.identity);
    }
}
