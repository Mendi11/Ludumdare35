using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    [SerializeField]
    private float m_Speed;

    Vector2 m_Movement;
    Rigidbody2D m_Rgb;


	// Use this for initialization
	void Start () {
        m_Speed = 5f;
        m_Rgb = GetComponent<Rigidbody2D>();

	}
	

    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

       m_Movement = new Vector2(h, v).normalized;
        m_Rgb.velocity = m_Movement * m_Speed;

    }
	// Update is called once per frame
	void Update () {
      

    }

    void OnCollisionEnter(Collision col)
    {
   
    }
    void OnCollisionExit(Collision col)
    {
    }
}
