using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float m_AddVelocity_y;
    [SerializeField] private float m_AddVelocity_x;
    [SerializeField] public TrailRenderer tr;
    public float speedMove;
    public float speedMoveWhenJump;
    public float speedClimb;
    //-------------------------------------
    private float playerDirection = 0f;
    [System.NonSerialized] public Rigidbody2D rd;
    float defaultGravity;
    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        defaultGravity = rd.gravityScale;
    }

    public void Jumping(bool isGround)
    {
        if (isGround) rd.velocity += new Vector2(playerDirection * m_AddVelocity_x, 0f);
        rd.velocity = new Vector2(rd.velocity.x, rd.velocity.y > 0 ? (rd.velocity.y * 0.7f) : 0f);
        rd.velocity += new Vector2(0f, m_AddVelocity_y * (isGround ? 1f : 0.8f));
        AudioManager.instance.PlaySfx("jump");
    }

    public void Moving(float direction, bool isGround)
    {
        if (isGround)
        {

            rd.velocity = new Vector2(direction * speedMove, rd.velocity.y);
        }
        else
        {
            rd.velocity = new Vector2(direction * speedMoveWhenJump, rd.velocity.y);
        }
        playerDirection = direction;
    }

    public void Climbing(float direction)
    {
        rd.gravityScale = 0f;
        rd.velocity = new Vector2(rd.velocity.x, speedClimb * direction);
    }

    public void ResetGravity()
    {
        rd.gravityScale = defaultGravity;
    }


}
