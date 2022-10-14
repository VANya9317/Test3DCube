namespace Value
{
    public class InputSpawnValue : InputCubesValue
    {
        protected override void OnCubesSpawnDataValueChanged()
        {
            _inputValue.text = _cubesSpawnController.CubeSpawnValue.ToString();
        }

        protected override void OnInputValueChanged(float value)
        {
            _cubesSpawnController.CubeSpawnValue = value;       
        }
    }
}