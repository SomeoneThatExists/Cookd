using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void Start()
    {
        UIEvents.current.onHealthUpdate += SetHealth;
    }

    public void SetMaxHealth(int _health)
    {
        slider.maxValue = _health;
        slider.value = _health;

        fill.color = gradient.Evaluate(1f);

    }

    public void SetHealth(int _newHealth)
    {
        slider.value = _newHealth;


        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
