using UnityEngine;
using UnityEngine.UI;

public class SpeedController : MonoBehaviour
{
    [SerializeField]
    private InputField _speedInputField;

    private GeneratorController _generator;

    private void Awake()
    {
        _generator = FindObjectOfType<GeneratorController>();
        _speedInputField.onValueChanged.AddListener(SetSpeed);
    }

    private void SetSpeed(string arg0)
    {
        if (float.TryParse(arg0, out float result))
        {
            _generator.Speed = result;
        }
    }
}