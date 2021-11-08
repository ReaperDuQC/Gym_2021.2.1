using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class SpawnShieldRipples : MonoBehaviour
{
    [SerializeField] private GameObject m_shieldRipples;
    private VisualEffect m_shieldRipplesVFX;

    private void OnCollisionEnter(Collision collision)
    {
        var ripples = Instantiate(m_shieldRipples, transform) as GameObject;
        m_shieldRipplesVFX = ripples.GetComponent<VisualEffect>();
        m_shieldRipplesVFX.SetVector3("SphereCenter", collision.contacts[0].point);

        Destroy(ripples, 2f);
    }
}
