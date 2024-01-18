using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;
    public TextMeshProUGUI textMeshPro;

    private void Update()
    {
        float roundedTemperature = Mathf.Round(temperature.Value * 10.0f) * 0.1f;
        textMeshPro.text = roundedTemperature.ToString();
    }
}
