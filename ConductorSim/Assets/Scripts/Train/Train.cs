using UnityEngine;

public class Train : MonoBehaviour
{
    [SerializeField] Transform passengerCarsContainer;
    public TrainCar[] passengerCars;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get all cars in the train
        passengerCars = new TrainCar[passengerCarsContainer.childCount];
        string debugInfo = $"Train cars:\n";

        for(int i = 0; i < passengerCarsContainer.childCount; i++)
        {
            passengerCars[i] = passengerCarsContainer.GetChild(i).GetComponent<TrainCar>();
            debugInfo += $"\t Car {i + 1}: {passengerCars[i]} [{passengerCars[i].carNumber}]\n";
        }
        print(debugInfo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //=====================================================================================================
    // Custom methods
    //=====================================================================================================

    public TrainCar FindTrainCar(int carNumber)
    {
        foreach(TrainCar car in passengerCars)
        {
            if(car.carNumber == carNumber) { return car; }
        }

        print($"Train car number {carNumber} not found");
        return null;
    }
}
