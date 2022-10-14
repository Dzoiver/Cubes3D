using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubesScript : MonoBehaviour
{
    [SerializeField] TMP_InputField speedIF;
    [SerializeField] TMP_InputField respawnIF;
    [SerializeField] TMP_InputField distanceIF;

    private void Start()
    {
        GetValues();
    }

    public void GetValues()
    {
        if (speedIF.text == "")
            speedIF.text = CubeScript.speed.ToString();
        else
            CubeScript.speed = float.Parse(speedIF.text);

        if (respawnIF.text == "")
            respawnIF.text = CubeScript.timeUntilRespawn.ToString();
        else
            CubeScript.timeUntilRespawn = float.Parse(respawnIF.text);

        if (distanceIF.text == "")
            distanceIF.text = CubeScript.deleteDistance.ToString();
        else
            CubeScript.deleteDistance = float.Parse(distanceIF.text);
    }
}
