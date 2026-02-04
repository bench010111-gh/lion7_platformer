using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float Speed = 5;
    public float jumpUp = 1;
    public Vector3 direction;

    Animator pAnimator;
    Rigidbody2D pRig2D;
    SpriteRenderer sp;

    void Start()
    {
        pAnimator = GetComponent<Animator>();
        pRig2D = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        direction = Vector2.zero;
    }

    void KeyInput()
    {
        direction.x = Input.GetAxisRaw("Horizontal");   // -1, 0, 1

        if (direction.x < 0)
            sp.flipX = true;
        else if (direction.x > 0)
            sp.flipX = false;
    }

    void FixedUpdate()
    {
        // ÁÂ¿ì ÀÌµ¿
        pRig2D.velocity = new Vector2(direction.x * Speed, pRig2D.velocity.y);
    }

    void Update()
    {
        KeyInput();
    }
}
