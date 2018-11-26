using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour {
    public Transform mainsun;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    private void FixedUpdate()
    {
        transform.LookAt(new Vector3(mainsun.position.x, 0f, mainsun.position.z));
    }
}
