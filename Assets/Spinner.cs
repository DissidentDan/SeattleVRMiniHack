using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour {
    public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
            this.transform.Rotate(Vector3.down * Time.deltaTime * speed);
        
    }
}
