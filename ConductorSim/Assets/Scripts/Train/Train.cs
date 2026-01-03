using UnityEngine;

public class Train : MonoBehaviour
{
    [SerializeField] Transform passengerCarsContainer;
    TrainCar[] passengerCars;

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
}
