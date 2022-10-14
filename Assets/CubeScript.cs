using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public static float speed = 1f;
    public static float timeUntilRespawn = 2f;
    public static float deleteDistance = 6f;
    float currentTime = 0f;
    MeshRenderer mesh;
    Vector3 startingPos = new Vector3();
    void Start()
    {
        startingPos = transform.position;
        mesh = GetComponent<MeshRenderer>();
    }

    void Respawn()
    {
        currentTime = 0f;
        transform.position = startingPos;
        mesh.enabled = true;
    }

    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
        if (Vector3.Distance(transform.position, startingPos) > deleteDistance)
        {
            mesh.enabled = false;
            currentTime += Time.deltaTime;
        }

        if (currentTime > timeUntilRespawn)
        {
            Respawn();
        }
    }
}
