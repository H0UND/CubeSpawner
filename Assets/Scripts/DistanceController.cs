using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceController : MonoBehaviour
{
    [SerializeField]
    private InputField _distanceInputField;

    private GeneratorController _generator;

    private void Awake()
    {
        _generator = FindObjectOfType<GeneratorController>();
        _distanceInputField.onValueChanged.AddListener(SetDistance);
    }

    private void SetDistance(string arg0)
    {
        if (float.TryParse(arg0, out float result))
        {
            _generator.Distance = result;
        }
    }
}
