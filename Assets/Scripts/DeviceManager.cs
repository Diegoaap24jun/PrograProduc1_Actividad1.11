using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeviceManager : MonoBehaviour
{
    public Text numberOfDevicesIndicator;
    public Text lastDeviceAdded;
    public Text completeDeviceList;
    public List<Device> devicesList;

    void Start()
    {
        devicesList = new List<Device>();

        lastDeviceAdded.text = "-";
        numberOfDevicesIndicator.text = "0";
        completeDeviceList.text = "";
    }

    public void AddMouse()
    {
        string deviceId = Random.Range(0, 100000).ToString("00000");

        int dpi = Random.Range(4, 100) * 100;

        Mouse g = new Mouse(deviceId, dpi);

        AddDevice(g);
    }

    public void AddKeyboard()
    {
        string deviceId = Random.Range(0, 100000).ToString("00000");

        int keys = Random.Range(5, 15) * 10;

        Keyboard g = new Keyboard(deviceId, keys);

        AddDevice(g);
    }

    public void AddDevice(Device d)
    {
        devicesList.Add(d);

        numberOfDevicesIndicator.text = devicesList.Count.ToString();
        lastDeviceAdded.text = d.ToString();
    }

    public void ListAllDevices()
    {
        string list = "";

        foreach(Device d in devicesList)
        {
            list += d.ToString() + System.Environment.NewLine;
        }

        completeDeviceList.text = list;
    }

    public void ClearList()
    {
        completeDeviceList.text = "";
    }
}
