using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveCube : MonoBehaviour, IFocusable, IInputClickHandler {
    public float Speed;
    public Vector3 ScaleChange;

    private bool Rotating;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Rotating)
            transform.Rotate(Vector3.up * Time.deltaTime * Speed);
	}

    public void OnFocusEnter()
    {
        Rotating = true;
    }

    public void OnFocusExit()
    {
        Rotating = false;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        transform.localScale += ScaleChange;
    }
}
