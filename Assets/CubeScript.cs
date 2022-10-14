using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public static float speed = 3f;
    public static float timeUntilRespawn = 2f;
    public static float deleteDistance = 10f;
    float currentTime = 0f;
    MeshRenderer mesh;
    Vector3 startingPos = new Vector3();
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (transform.position.magnitude > deleteDistance)
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
