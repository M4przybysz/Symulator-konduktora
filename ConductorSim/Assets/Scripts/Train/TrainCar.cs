using UnityEngine;

public class TrainCar : MonoBehaviour
{
    [SerializeField] Transform seatsContainer;
    [SerializeField] int carNumber;
    public PassengerSeat[] passengerSeats;
    string debugInfo = "";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get all seats in a train car
        passengerSeats = new PassengerSeat[seatsContainer.childCount];
        debugInfo = $"Car {carNumber} seats:\n";

        for(int i = 0; i < seatsContainer.childCount; i++)
        {
            passengerSeats[i] = seatsContainer.GetChild(i).GetComponent<PassengerSeat>();
            debugInfo += $"\t seat {i + 1}: {passengerSeats[i]} [{passengerSeats[i].seatNumber}, {passengerSeats[i].isTaken}]\n";
        }
        print(debugInfo);
    }
}
