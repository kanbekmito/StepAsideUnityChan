using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemD : MonoBehaviour {
    private GameObject unitychan;
	// Use this for initialization
	void Start () {
        unitychan = GameObject.Find("unitychan");

    }
	
	// Update is called once per frame
	void Update () {
        if (gameObject.transform.position.z < unitychan.transform.position.z - 5)
        {
            Destroy(gameObject);
        }
	}
}
