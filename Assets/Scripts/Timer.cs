﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    private float startTime;
	public static float tempo;

	// Use this for initialization
	void Start () {

        startTime = Time.time;

	}
	
	// Update is called once per frame
	void Update () {

		if (Fim.terminou)
            return;
		
		tempo = Time.time - startTime + ResetPosition.cont;
        string minutes = ((int) tempo / 60).ToString();
        string seconds = (tempo % 60).ToString("f0");
        if (tempo < 10)
            timerText.text = "0" + minutes + ":0" + seconds;
        else
            timerText.text = "0" + minutes + ":" + seconds;

    }
}
