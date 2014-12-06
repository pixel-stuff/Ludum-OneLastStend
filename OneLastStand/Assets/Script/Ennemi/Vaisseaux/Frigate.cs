﻿using UnityEngine;
using System.Collections;

public class Frigate : Ship {

	public Frigate() : base() {
		
		_TYPE = Enum_ShipType.Frigate;
		_pv = ConstantesManager.FRIGATE_PV;
		_degatShot= ConstantesManager.FRIGATE_SHOOT_DMG;
		_degatKamikaze = ConstantesManager.FRIGATE_KAMIKAZE_DMG;
		_score=ConstantesManager.FRIGATE_SCORE;
		_normalSpeed=ConstantesManager.FRIGATE_NORME_SPEED;
		_timeBetweenAttack = ConstantesManager.FRIGATE_TIME_BETWEEN_ATTACK;
		_variationTimeBetweenAttackPercent = ConstantesManager.VARIATION_TIME_BETWEEN_ATTACK_PERCENT;
		
	}

		
	// Update is called once per frame
	void Update () {
	
	}
}
