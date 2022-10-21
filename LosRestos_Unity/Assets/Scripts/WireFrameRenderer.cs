using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireFrameRenderer : MonoBehaviour
{
    public bool StartInWireFrame=true;
     
     
    

    void OnPreRender()
    {
         if (StartInWireFrame){
            GL.wireframe = true;
        } else {
            GL.wireframe = false;
        }
    }




    void OnPostRender()
    {
       if (StartInWireFrame){
            GL.wireframe = true;
        } else {
            GL.wireframe = false;
        }
    }
}


