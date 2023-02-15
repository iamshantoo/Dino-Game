using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsAnimation : MonoBehaviour
{
    private void Update()
    {
        transform.position += Vector3.left * Time.deltaTime;
    }
}
