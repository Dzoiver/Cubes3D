using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubesScript : MonoBehaviour
{
    [SerializeField] TMP_InputField speedIF;
    [SerializeField] TMP_InputField respawnIF;
    [SerializeField] TMP_InputField distanceIF;
    [SerializeField] GameObject cube;

    public void SpawnCube()
    {
        GameObject c = Instantiate(cube, transform);
        CubeScript script = c.GetComponent<CubeScript>();
        script.Speed = float.Parse(speedIF.text);
        script.RespawnTime = float.Parse(respawnIF.text);
        script.Distance = float.Parse(distanceIF.text);
    }

    public void GetValues()
    {
        if (speedIF.text == "")
            speedIF.text = "3";

        if (respawnIF.text == "")
            respawnIF.text = "2";

        if (distanceIF.text == "")
            distanceIF.text = "10";
    }
}
