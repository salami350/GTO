﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PokemonController : MonoBehaviour
{
    [HideInInspector]
    public GameController gameController;

    public string name;
    [HideInInspector]
    public PlayerController owner;
    [HideInInspector]
    public Color originalColor;

    [HideInInspector]
    //0 is down, 1 is left, 2 is up, 3 is right
    public int direction;
    public int hp;
    public decimal movementModifier;

    public List<Attack> attacks = new List<Attack>();

    // Use this for initialization
    void Start()
    {
        originalColor = gameObject.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update(){}

    void OnMouseDown()
    {
        gameController.selectedUnit = this;
    }
}