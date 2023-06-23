using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chainsaw : MonoBehaviour
{
    [SerializeField]List<GameObject> path = new List<GameObject>();
    public float speed;
    Rigidbody2D rd;
    GameObject currentTarget;
    int index = 0;
    bool m_FacingRight = true;

    private void Start() {
        index  = 0;
        rd = GetComponent<Rigidbody2D>();    
        currentTarget =  path[index];
    }
    private void Update() {
        EnemyTwo();
    }

    private void EnemyTwo(){
        if(Vector2.Distance(transform.position,currentTarget.transform.position) <= 1)
        {
            if(index == 0){
                index ++;
            }
            else index = 0;
            currentTarget = path[index];
        }
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, speed*Time.deltaTime);

        if(index == 1 && m_FacingRight)
        {
            Flip();
        }
        else if ( index == 0 && !m_FacingRight)
        {
            Flip();
        }
    }
    private void Flip()
	{
		m_FacingRight = !m_FacingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
