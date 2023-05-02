using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
	public GameObject TV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	transform.position += new Vector3(-0.5f, 0, -0.5f) * Time.deltaTime;
    	if( transform.position.x < TV.transform.position.x-1 && transform.position.z < TV.transform.position.z-1)
    	{
    		transform.rotation = Quaternion.Euler(0.0f, 39.7f, 0.0f);
    	}
    }
}
