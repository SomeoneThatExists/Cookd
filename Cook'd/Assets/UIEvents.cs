using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIEvents : MonoBehaviour
{
    public static UIEvents current;

    public void Awake()
    {
        current = this;
    }

    public event Action<int> onHealthUpdate;
    public void HealthUpdate(int _newHealth)
    {
        if (onHealthUpdate != null)
            onHealthUpdate(_newHealth);
    }
}
