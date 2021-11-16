using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;

public class ShootBall : MonoBehaviour
{
    [SerializeField] private GameObject m_ballPrefab;
    [SerializeField] private int m_initialAmout = 25;
    [SerializeField] private int m_maximumAmout = 25;

    [SerializeField] private float m_force;
    private ObjectPool<GameObject> m_pool;

    private void Start()
    {
        m_pool = new ObjectPool<GameObject>(() =>
        {
            return Instantiate(m_ballPrefab);
        }, ball =>
        {
            ball.gameObject.SetActive(true);
        }, ball =>
        {
            ball.gameObject.SetActive(false);
        }, ball =>
        {
            Destroy(ball);
        }, false, m_initialAmout, m_maximumAmout);
    }
    public void Shoot(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            var ball = m_pool.Get();
            ball.transform.position = transform.position;
            var rb = ball.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.AddForce(transform.forward.normalized * m_force);

            StartCoroutine(Release(ball));
        }
    }

    private IEnumerator Release(GameObject ball)
    {
        yield return new WaitForSeconds(5f);
        m_pool.Release(ball);
    }
}
