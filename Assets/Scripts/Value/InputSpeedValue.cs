namespace Value
{
    public class InputSpeedValue : InputCubesValue
    {
        protected override void OnCubesSpawnDataValueChanged()
        {
            _inputValue.text = _cubesSpawnController.CubeValueSpeed.ToString();
        }

        protected override void OnInputValueChanged(float value)
        {
            _cubesSpawnController.CubeValueSpeed = value;
        }
    }
}