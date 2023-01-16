using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. ��ġ ����
// 2. ���� ����

public class PlayerController : MonoBehaviour
{
    SpriteRenderer rend;
    Animator animator;
    Rigidbody2D myrigidbody;

    [SerializeField]
    float _speed = 40.0f;
    float jump_speed = 150f;


    void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard; // ��� Ű�� ������ �Լ� ����
        Managers.Input.KeyAction += OnKeyboard;
        animator = GetComponent<Animator>();
        myrigidbody = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }

    void OnKeyboard()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
            rend.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
            rend.flipX = false;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector2.up * Time.deltaTime * jump_speed);
        }
        if (Input.GetMouseButton(0) && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
        {
            animator.SetTrigger("attack");
        }
    }
}
