using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    Transform m_Player;
    Camera m_Camera;

    float dampTime = 0.3f; //offset from the viewport center to fix damping
    Vector3 velocity = Vector3.zero;


    // Use this for initialization
    void Start () {
        m_Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().transform;
        m_Camera = GetComponent<Camera>();
	}

    // Update is called once per frame

    void FixedUpdate()
    {
        if (m_Player)
        {
            Vector3 point = m_Camera.WorldToViewportPoint(m_Player.position);
            Vector3 delta = m_Player.position - m_Camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

    }

	void Update () {

    }

    void LateUpdate()
    {
        
    }
}
