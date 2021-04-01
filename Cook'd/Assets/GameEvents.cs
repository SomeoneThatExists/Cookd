using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    public void Awake()
    {
        current = this;
    }

    public event Action onMoving;
    public void Moving()
    {
        if (onMoving != null)
            onMoving();
    }

    public event Action<int> onDamageEntity;
    public void DamageEntity(int _amount)
    {
        if (onDamageEntity != null)
            onDamageEntity(_amount);
    }

    public event Action<int> onHealEntity;
    public void HealEntity(int _amount)
    {
        if (onHealEntity != null)
            onHealEntity(_amount);
    }
}
