﻿using UnityEngine;
using System.Collections;

public class SingleDamageReceiver : DamageReceiver
{
    public override void ReceiveDamage(object value)
    {
        EventManager.TriggerEvent("HomeTowerAttacked", value);
    }
}
