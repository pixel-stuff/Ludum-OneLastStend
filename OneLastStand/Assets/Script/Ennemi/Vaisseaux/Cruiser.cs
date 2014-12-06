﻿using UnityEngine;
using System.Collections;

public class Cruiser : Ship {

	public Cruiser() : base() {
		
		_TYPE = Enum_ShipType.Cruiser;
		_pv = ConstantesManager.CRUISER_PV;
		_degatShot= ConstantesManager.CRUISER_SHOOT_DMG;
		_degatKamikaze = ConstantesManager.CRUISER_KAMIKAZE_DMG;
		_score=ConstantesManager.CRUISER_SCORE;
		_normalSpeed=ConstantesManager.CRUISER_NORME_SPEED;
		_timeBetweenAttack = ConstantesManager.CRUISER_TIME_BETWEEN_ATTACK;
		_variationTimeBetweenAttackPercent = ConstantesManager.VARIATION_TIME_BETWEEN_ATTACK_PERCENT;
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
