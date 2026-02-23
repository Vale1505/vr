using UnityEngine;
using UnityEngine.XR;

public class HMD_manager : MonoBehaviour
{
    [SerializeField] GameObject xrPlayer;
    [SerializeField] GameObject fpsPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Debug.Log("Using device:"+ XRSettings.loadedDeviceName);  
      if (XRSettings.isDeviceActive || XRSettings.loadedDeviceName == "OpenXR Display")
        {
            Debug.Log("Using device XR Player with HMD : " + XRSettings.loadedDeviceName);
            fpsPlayer.SetActive(false);
            xrPlayer.SetActive(true);
        }
        else
        {
            Debug.Log("No HMD detected, using FPS player");
            fpsPlayer.SetActive(true);
            xrPlayer.SetActive(false);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
