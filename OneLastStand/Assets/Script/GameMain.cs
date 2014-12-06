﻿using UnityEngine;
using System.Collections;

public class GameMain : MonoBehaviour {

	EnnemiManager _ennemiManager;
	PlayerManager _playerManager;
	UIManager _uiManager;

	Enum_StateGame _enumStateGame;

	// Use this for initialization
	void Start () {
		_ennemiManager = new EnnemiManager ();
		_playerManager = new PlayerManager ();
		_uiManager = new UIManager ();
		_enumStateGame = Enum_StateGame.Construction;
	}
	
	// Update is called once per frame
	void Update () {
		switch (_enumStateGame) {
			case Enum_StateGame.Construction:
				UpdateConstruction();
				break;
			case Enum_StateGame.Shoot:
				UpdateShoot();
				break;
			default:
				Debug.Log("Wrong StateGame in GameMain");
				break;
		}
	}

	void UpdateConstruction () {
		//_ennemiManager.UpdateConstruction ();
		_playerManager.UpdateConstruction ();
		_uiManager.UpdateConstruction ();
	}

	void UpdateShoot () {
		//_ennemiManager.UpdateShoot ();
		_playerManager.UpdateShoot ();
		_uiManager.UpdateShoot ();
	}
}
