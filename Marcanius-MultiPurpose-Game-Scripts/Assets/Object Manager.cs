﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class which keeps track of all objects in unity that need to be reached by others
/// </summary>
public class ObjectManager : MonoBehaviour {

	#region Managers	
	public iInputSystem InputMethod;
	public StateManager StateManager;
	#endregion

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Awake() {
		StateManager = new StateManager();
	}

	/// <summary>
	/// Use this as a first update
	/// </summary>
	void Start() {
		InputMethod = InputManager.GetInputSystem();
	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update() {

	}
}