using Main;
using TMPro;
using UnityEngine;

namespace Value
{
    public abstract class InputCubesValue : MonoBehaviour
    {
        [SerializeField] protected CubesSpawnController _cubesSpawnController;
        [SerializeField] protected TMP_InputField _inputValue;

        protected virtual void Start()
        {
            _cubesSpawnController.OnSpawnDataValueChanged += OnCubesSpawnDataValueChanged;
            _inputValue.onEndEdit.AddListener(ValueChanged);
        }

        protected void ValueChanged(string inputValue)
        {
            var value = float.TryParse(inputValue, out var floatValue);
            if (value)
            {
                OnInputValueChanged(floatValue);             
            }
        }

        protected abstract void OnInputValueChanged(float value);

        protected abstract void OnCubesSpawnDataValueChanged();
    }
}