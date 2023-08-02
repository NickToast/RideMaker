/*Create at least 4 different vehicles using any of the constructors (use each constructor at least once)
Put all the vehicles you created into a List
Loop through the List and have each vehicle run its ShowInfo() method
Make one of the vehicles Travel 100 miles
Print the information of the vehicle to verify the distance traveled went up*/

Vehicle AE86 = new Vehicle("AE86", 4, "Black", true);
Vehicle RX7 = new Vehicle("1994 Mazda RX-7", 2, "Black", true);
Vehicle Rav4 = new Vehicle("2002 Rav-4", "White");
Vehicle Corolla = new Vehicle("2018 Toyota Corolla", "White");

List<Vehicle> AllVehicles = new List<Vehicle>();
AllVehicles.Add(AE86);
AllVehicles.Add(RX7);
AllVehicles.Add(Rav4);
AllVehicles.Add(Corolla);

foreach (Vehicle car in AllVehicles)
{
    car.ShowInfo();
}

Rav4.Travel(100);