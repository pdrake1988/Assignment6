namespace Assignment6.Vehicle
{
    public class Vehicle
    {
        public Vehicle(string model, string make, float weight, float price, int speed)
        {
            Model = model;
            Make = make;
            Weight = weight;
            Price = price;
            Speed = speed;
        }

        public string Model { get; set; }
        public string Make { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
        private protected int Speed { get; set; }

        public void SpeedUp(int speed)
        {
            this.Speed += speed;
        }

        public void SlowDown(int speed)
        {
            this.Speed -= speed;
        }

        public void Brake()
        {
            this.Speed = 0;
        }
    }
}
