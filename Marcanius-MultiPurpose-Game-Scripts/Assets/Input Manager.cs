using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	iInputSystem instance;

	void Awake() {
		GetInputSystem();
	}

	/// <summary>
	/// Returns the right input system for this platform
	/// </summary>
	public iInputSystem GetInputSystem() {
		if ( instance == null ) { instance = CreateInstance(); }

		return instance;
	}

	/// <summary>
	/// Creates a new instance of the right input system for this platform
	/// </summary>
	static iInputSystem CreateInstance() {
#if UNITY_STANDALONE
		return new StandaloneInputSystem();
#endif
	}
}

public enum GameAction { }

public interface iInputSystem {
	bool GetInput(GameAction action);
	Vector3 GetCursorPosition();
	Vector3 GetCursorWorldPosition(float depth = 0);
}

public class StandaloneInputSystem : iInputSystem {
	public bool GetInput(GameAction action) {
		return Input.GetButtonDown(action.ToString());
	}

	public Vector3 GetCursorPosition() {
		return Input.mousePosition;
	}

	public Vector3 GetCursorWorldPosition(float depth = 0) {
		return new Vector3();
	}
}