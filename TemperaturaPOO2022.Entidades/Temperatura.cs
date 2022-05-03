namespace TemperaturaPOO2022.Entidades
{
    public class Temperatura
    {
        public Escala Escala { get; set; }

        public double Grados { get; set; }

        public Temperatura()
        {
            
        }

        public Temperatura(Escala escala, double valor)
        {
            this.Escala = escala;
            this.Grados = valor;

        }

        public bool Validar()
        {
            if (Escala==Escala.Celsius)
            {
                return this.Grados >= -80 && this.Grados <= 80;
            }

            return this.Grados >= -112 && this.Grados <= 176;
        }

        private double GetFahrenheit() => 1.8 * this.Grados + 32;
        private double GetCelsius() => (this.Grados - 32) / 1.8;

        public double GetConversion()
        {
            return this.Escala == Escala.Celsius ? GetFahrenheit() : GetCelsius();
        }
    }
}
