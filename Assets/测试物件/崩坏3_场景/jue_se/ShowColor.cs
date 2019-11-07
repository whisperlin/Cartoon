using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class ShowColor : MonoBehaviour {

    public Vector4 input;

    public Color color;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        color = new Color(input.x, input.y, input.z, input.w);

    }
}
