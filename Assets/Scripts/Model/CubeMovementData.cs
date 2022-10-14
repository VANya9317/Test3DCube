namespace Model
{
    public class CubeMovementData
    {
        private float _movementSpeed;
        private float _movementDistance;

        public float MovementSpeed => _movementSpeed;
        public float MovementDistance => _movementDistance;

        public CubeMovementData(float movementSpeed, float movementDistance)
        {
            _movementSpeed = movementSpeed;
            _movementDistance = movementDistance;
        }
    }
}