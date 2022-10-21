using UnityEngine;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    public bool StartInVR = true;
    public GameObject xrOrigin;
    public GameObject FirstPersonPlayer;
    
    
    void Start()
    {
// StartInVr on/off
        if (StartInVR){

            //Checkeo xr settings
       var xrSettings = XRGeneralSettings.Instance;

       if (xrSettings == null){
            Debug.Log(message:"XRGeneralSettings is null");
            return; 
       }

//Checkeo xr Manager
       var xrManager = xrSettings.Manager;

       if (xrManager == null){
            Debug.Log(message:"XRManagerSettings is null");
            return; 
       }

//Checkeo Xr Loader
        var xrLoader = xrManager.activeLoader;

       if (xrLoader == null){
            Debug.Log(message:"XRLoader is null");
        //Si el casco no esta conectado entonces se apaga XROrigins y se prende el FirstPersonPlayer
            
            xrOrigin.SetActive(false);
            FirstPersonPlayer.SetActive(true);

            return; 
       }
      
      
        //Si el casco esta conectado entonces se prendo XROrigins y apago el FirstPersonPlayer
        
        Debug.Log(message:"XRLoader is NOT null");
            
            xrOrigin.SetActive(true);
            FirstPersonPlayer.SetActive(false);


    }
    else {
        xrOrigin.SetActive(false);
        FirstPersonPlayer.SetActive(true);
    }






    }
}
  