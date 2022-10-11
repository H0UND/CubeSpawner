using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnTimeController : MonoBehaviour
{
    [SerializeField]
    private InputField _respawnTimeInputField;

    private GeneratorController _generator;

    private void Awake()
    {
        _generator = FindObjectOfType<GeneratorController>();
        _respawnTimeInputField.onValueChanged.AddListener(SetRespawnTime);
    }

    private void SetRespawnTime(string arg0)
    {
        if (float.TryParse(arg0, out float result))
        {
            _generator.RespawnTime = result;
        }
    }
}
