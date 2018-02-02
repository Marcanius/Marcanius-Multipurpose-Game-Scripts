using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// All possible game states
/// </summary>
enum GameStates {
	FirstState,
	SecondState,
	InvalidState
}

public class StateManager : MonoBehaviour {

	GameStates currentState;

	#region State-specific variables
	// Keep private, and use properties to change them

	#endregion

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Awake() {

	}

	/// <summary>
	/// Use this as a first update
	/// </summary>
	void Start() {

	}

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update() {

	}

	/// <summary>
	/// Goes to the next state, using <paramref name="newState"/> if necessary
	/// </summary>
	/// <param name="newState">The state to change to</param>
	public void NextState(string newState) {
		// Check that it's a valid state
		if ( GamestateFromString(newState) == GameStates.InvalidState )
			return;

		// Change to the new state
		ChangeState(GamestateFromString(newState));
	}

	/// <summary>
	/// Changes the gamestate over to the new state.
	/// </summary>
	/// <param name="newState">The state to change over to></param>
	void ChangeState(GameStates newState) {
		// Perform state closing actions

		// Change the state

		// Perform state opening actions
	}

	/// <summary>
	/// Creates a gamestate from the provided string
	/// </summary>
	/// <param name="input">the string to convert to a gamestate</param>
	GameStates GamestateFromString(string input) {
		GameStates result = GameStates.InvalidState;

		if ( input == null )
			return result;

		switch ( input.ToLower() ) {
		case "first":
			result = GameStates.FirstState;
			break;
		case "second":
			result = GameStates.SecondState;
			break;
		default:
			break;
		}

		if ( result == GameStates.InvalidState )
			Debug.Log("Invalid gamestate created");

		return result;
	}
}
