using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows.Speech;

// General Scene Changer Logic
// This script should be attached to the GameObject that goes onto the
// activation track of a given scene's timeline, and is responsible for accepting
// the various different inputs the user can specify during an interaction phase
// to determine what scene to switch to

public class InteractionSceneChanger : MonoBehaviour
{
	// Declare private objects for the keywordRecognizer and the
	// dictionary that maps detected keywords to corresponding functions
	private KeywordRecognizer keywordRecognizer;
	private Dictionary<string, Action> actions = new Dictionary<string, Action>();


	/*****************************
	STATE FUNCTIONS
	*****************************/
	// Called every time the associated GameObject is enabled 
	// at the frame in which it is enabled
    void OnEnable()
    {
    	// Map keywords to the transition functions
    	// YES words
    	actions.Add("yes", SceneChangeYes);
    	actions.Add("yeah", SceneChangeYes);
    	actions.Add("yup", SceneChangeYes);
    	actions.Add("sure", SceneChangeYes);
    	actions.Add("definitely", SceneChangeYes);
    	actions.Add("for sure", SceneChangeYes);

    	// NO words
    	actions.Add("nope", SceneChangeNo);	
    	actions.Add("no", SceneChangeNo);	

    	// Instantiate the keyword recognizer with our mapping dict
    	keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
    	keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;	
    	keywordRecognizer.Start();

    }

    // Callback function for when speeech is recognized. Prints out the
    // recognized speech to debug console, and invokes the action associated
    // with that recognized keyphrase as specified in the actions dict
    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
    	Debug.Log(speech.text);
    	actions[speech.text].Invoke();
    }

    // Update cycle running once per frame as long as the GameObject
    // with this script attached to it is active
    void Update()
    {
    	// Map Y and N key presses to the scene transition functions
        if(Input.GetKeyDown("y") || Input.GetKey(KeyCode.Mouse0)) {
        	SceneChangeYes();
        } else if(Input.GetKeyDown("n") || Input.GetKey(KeyCode.Mouse1)) {
        	SceneChangeNo();
        }
    }

	/*****************************
	TRANSITION / HELPER FUNCTIONS
	*****************************/

	// Helper method to determine the successor state. Accepts either
	// "Y" or "N" depending on which transition wrapper function invokes it
	// which is used to construct the name of the successor state to pass into
	// SceneManager to load
	// TODO: Modify this logic to account for the transition from end of BG to start of interaction sequence
	private string DetermineSuccessor(string decision)
	{
		string currScene = SceneManager.GetActiveScene().name;
		// If it's an interaction scene, append the decision string 
		string successor = currScene + decision;		
		return successor;
	}

	// Core transition methods leverage the DetermineSuccessor helper method
	// to get the name of the successor state, and use SceneManager to transition to
	// said state. These deterministically change scenes; the controls on user input
	// are handled by the state functions
	private void SceneChangeYes()
	{
		string successor = DetermineSuccessor("Y");
		// Note: The "Single" LoadSceneMode guarantees that we close the current
		// scene and only open the single scene we pass here. Additive will keep
		// the current scene open so we should NOT use additive
		SceneManager.LoadScene(successor, LoadSceneMode.Single);
	}

	private void SceneChangeNo()
	{
		string successor = DetermineSuccessor("N");
		SceneManager.LoadScene(successor, LoadSceneMode.Single);
	}

}
 