namespace Value
{
    public class InputDistanceValue : InputCubesValue
    {
        protected override void OnCubesSpawnDataValueChanged()
        {
            _inputValue.text = _cubesSpawnController.CubeDistanceValue.ToString();
        }

        protected override void OnInputValueChanged(float value)
        {
            _cubesSpawnController.CubeDistanceValue = value;
        }
    }
}