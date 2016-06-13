﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DictionaryAgent : MonoBehaviour {

	private static DictionaryAgent instanceDico;
	private static Dictionary<string, Agent> dictionary = new Dictionary<string, Agent>();


	public static DictionaryAgent Instance
	{
		get
		{
			if (instanceDico == null) instanceDico = new DictionaryAgent();
			return instanceDico;
		}
	}

	public static Agent getAgent(string nameAgent){
		Agent a;
		if (dictionary.TryGetValue (nameAgent, out a)) {
			return a;
		} else {
			return null;
		}

	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}