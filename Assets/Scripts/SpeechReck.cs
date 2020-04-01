using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.SceneManagement;


public class SpeechReck : MonoBehaviour {

	// Use this for initialization
	private KeywordRecognizer keywordRecognizer;
	private Dictionary<string, Action> actions = new Dictionary<string, Action>();




	void Start () {
		actions.Add("machine", Machine);
		//actions.Add("backward", Back);
		print("listening");
		keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
		keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
		keywordRecognizer.Start();
	}

	// Update is called once per frame
	private void RecognizedSpeech (PhraseRecognizedEventArgs speech) {

		Debug.Log(speech.text);
		actions[speech.text].Invoke();
	}

	/*public void Eight()
	{


	}*/

	private void Machine()
	{
		// SceneManager.LoadScene(1);
		endGame.GameOver = true;
	}
}
