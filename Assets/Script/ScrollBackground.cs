using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollSpeed = 10f;
    public float resetPosition = -20f;
    public float startPosition = 20f;

    private void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, startPosition - resetPosition);
        transform.position = new Vector3(-newPosition + startPosition, transform.position.y, transform.position.z);
    }
}


