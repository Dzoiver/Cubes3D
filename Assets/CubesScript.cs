using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubesScript : MonoBehaviour
{
    public float Speed = 3f;
    public float TimeUntilRespawn = 2f;
    public float DeleteDistance = 10f;
    [SerializeField] TMP_InputField speedIF;
    [SerializeField] TMP_InputField respawnIF;
    [SerializeField] TMP_InputField distanceIF;

    public void GetValues()
    {
        Speed = float.Parse(speedIF.text);
        TimeUntilRespawn = float.Parse(respawnIF.text);
        DeleteDistance = float.Parse(distanceIF.text);
        CubeScript.speed = Speed;
        CubeScript.timeUntilRespawn = TimeUntilRespawn;
        CubeScript.deleteDistance = DeleteDistance;
    }
}
