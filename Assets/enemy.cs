using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    GameObject[] points = new GameObject[4];
    int targetIndex = 0;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        points = GameObject.FindGameObjectsWithTag("points");
        transform.position = points[targetIndex].transform.position;
        transform.LookAt(points[targetIndex].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, points[targetIndex].transform.position) < 0.1f)
        {
            targetIndex = Random.Range(0, 4);
            transform.LookAt(points[targetIndex].transform.position);
        }
    }
}
