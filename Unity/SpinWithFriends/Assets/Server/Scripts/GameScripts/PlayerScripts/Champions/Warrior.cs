﻿using UnityEngine;

public class Warrior : Champion
{
    public Warrior()
    {
        healthReset = 100;
        health = healthReset;
        speedReset = 3;
        speed = speedReset;
        abilityTimerReset = 12;
        abilityTime = 0;
        abilityCooldownReset = 250;
        abilityCooldown = 0;

        weapon = new Spear();
    }

    public override void UseAbility()
    {
        if (abilityCooldown > 0)
        {
            return;
        }

        weapon.spinSpeed *= 5f;
        ((Axe)weapon).ignoreBounce = true;

        abilityTime = abilityTimerReset;
        abilityCooldown = abilityCooldownReset;
    }


    public override void ResetAbility()
    {
        weapon.spinSpeed = weapon.spinSpeedReset * weapon.direction;
        ((Axe)weapon).ignoreBounce = false;
    }
}