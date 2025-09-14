using System;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        Vector3 movement = -transform.forward * speed;
        transform.Translate(movement * Time.deltaTime);
    }
}
