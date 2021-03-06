﻿//Original Scripts by IIColour (IIColour_Spectrum)

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Diagnostics;
public class ServerHandler : MonoBehaviour
{
    public IEnumerator TestConnection()
    {
        WWW www = new WWW("http://localhost:8080/?token=anonymous&a=connect");
        yield return www;
        if (!string.IsNullOrEmpty(www.error)) {
            GlobalVariables.global.debug("Error: " + www.error);
        } else {
            GlobalVariables.global.debug("Connected to service successfully.");
        }
    }
}