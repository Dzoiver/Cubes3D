using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public float Speed = 3f;
    public float RespawnTime = 2f;
    public float Distance = 10f;
    float currentTime = 0f;
    public MeshRenderer mesh;
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
        transform.Translate(0, -Speed * Time.deltaTime, 0);
        if (Vector3.Distance(transform.position, startingPos) > Distance)
        {
            mesh.enabled = false;
            currentTime += Time.deltaTime;
        }

        if (currentTime > RespawnTime)
        {
            Respawn();
        }
    }
}
