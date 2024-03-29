﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public enum ScreenEdge { LEFT, RIGHT, TOP, BOTTOM };
    public ScreenEdge screenEdge;
    public float yOffset;
    public float xOffset;

	// Use this for initialization
	void Start () 
    {
        Vector3 newPosition = transform.position;
        Camera camera = Camera.main;

        // 2
        switch (screenEdge)
        {
            // 3
            case ScreenEdge.RIGHT:
                newPosition.x = camera.aspect * camera.orthographicSize + xOffset;
                newPosition.y = yOffset;
                break;

            // 4
            case ScreenEdge.TOP:
                newPosition.y = camera.orthographicSize + yOffset;
                newPosition.x = xOffset;
                break;
        }
        // 5
        transform.position = newPosition;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
