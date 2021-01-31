using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Comunicacion : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM4", 115200); //MODIFY THE COM PORT FOR YOUR NEEDS
    public string receivedstring;
    public GameObject carrito;
    public Vector3 rot;
    public Vector3 rot2;
    public string data;

    void Start()
    {
        stream.Open();
    }

    void Update()
    {
        receivedstring = stream.ReadLine(); //Read
        stream.BaseStream.Flush(); //ClearS
        string[] data = receivedstring; 
    }
}