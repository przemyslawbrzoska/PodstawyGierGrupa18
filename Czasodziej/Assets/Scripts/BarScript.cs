﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour {

    [SerializeField]
    private float fillAmount;

    [SerializeField]
    private Image content;

    private MonsterMovement refScript;

    public GameObject owner;

    // Use this for initialization
    void Start ()
    {
        refScript = owner.GetComponent<MonsterMovement>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        fillAmount = refScript.speed;
        HandleBar();
	}

    private void HandleBar()
    {
        content.fillAmount = Map(fillAmount,5,30,0,1);
    }

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {

        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
