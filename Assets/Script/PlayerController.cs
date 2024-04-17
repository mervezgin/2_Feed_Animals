using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject[] foodPrefab;

    float horizontalInput;
    float playerSpeed = 0.5f;
    float leftBoundary = -20.0f;
    float rightBoundary = 20.0f;
    float xRange = 20.0f;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * playerSpeed);

        if (transform.position.x > rightBoundary)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < leftBoundary)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            int foodIndex = Random.Range(0, foodPrefab.Length);
            Instantiate(foodPrefab[foodIndex], transform.position, foodPrefab[foodIndex].transform.rotation);
        }
    }
}
