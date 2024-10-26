namespace safasadiqsafasadiq_hw
{
    class Vehicle
    {
        public string brande;


    }
    class MotorVehicle : Vehicle
    {
        public string modelname;
    }
    class car : MotorVehicle
    {
        public car(string Brandcar = "Renoulte", string Modelname_car = "safrane _ 2024")
        {
            brande = Brandcar;
            modelname = Modelname_car;
        }
    }
    class truck : MotorVehicle
    {
        public truck(string Brandetruck = "chevrolet", string Modeltruck = "silverado")
        {
            brande = Brandetruck;
            modelname = Modeltruck;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            car car_obj = new car();
            truck truck_obj = new truck();


            Console.WriteLine("car brand : " + car_obj.brande);
            Console.WriteLine("car model : " + car_obj.modelname + "\n");

            Console.WriteLine("truck name : " + truck_obj.brande);
            Console.WriteLine("truck model : " + truck_obj.modelname);



            Console.ReadLine();
        }
    }
}


