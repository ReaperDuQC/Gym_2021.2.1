using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOverTimes : MonoBehaviour
{
    [SerializeField]
     private float m_speed;
    [SerializeField]
    private Vector3 m_rotation;

    void Update()
    {
        transform.Rotate(m_rotation * (m_speed * Time.deltaTime));
    }
}
