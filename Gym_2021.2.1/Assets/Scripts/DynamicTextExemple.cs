using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicTextExemple : MonoBehaviour
{
    [SerializeField] private int m_killCount;

    public int GetKillCount()
    {
        return m_killCount;
    }
}
