﻿// *********************************************************************************************************************
// File: ButtonSceneChange.cs
// Purpose: On click, transfers to a new scene
// Project: Fife College Unity Toolkit
// Copyright Fife College 2018
// *********************************************************************************************************************


// *********************************************************************************************************************
#region Imports
// *********************************************************************************************************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// The scene management library has to be included
using UnityEngine.SceneManagement;
#endregion
// *********************************************************************************************************************


// *********************************************************************************************************************
public class ButtonSceneChange : MonoBehaviour {
	// *********************************************************************************************************************


	// *****************************************************************************************************************
	#region Variables
	// *****************************************************************************************************************
	// Exposed Variables
	[Tooltip("What scene should we go to?")]
	public string m_sceneName;
	[Tooltip("What sound should we play on click?")]
	public AudioClip m_clickSound;
	#endregion
	// *****************************************************************************************************************


	// *****************************************************************************************************************
	#region Unity Functions
	// *****************************************************************************************************************
	// Called when the user clicks on this collider with the mouse
	void OnMouseUpAsButton()
	{
		// If we have a sound clip, play it at the current location
		if (m_clickSound != null)
		{
			AudioSource.PlayClipAtPoint(m_clickSound, transform.position);
		}

		// Load the scene using the scene manager
		SceneManager.LoadScene(m_sceneName);
	}
	#endregion
	// *****************************************************************************************************************


}
// *********************************************************************************************************************
