using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    [SerializeField] private string m_gameSeed = "default";
    [SerializeField] private int m_currentSeed = 0;

    [SerializeField] private bool m_isUsingSeed = false;
    private void Awake()
    {
        if (m_isUsingSeed)
        {
            m_currentSeed = m_gameSeed.GetHashCode();
            Random.InitState(m_currentSeed);
        }
    }
}
