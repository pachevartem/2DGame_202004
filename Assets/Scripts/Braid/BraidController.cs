using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BraidGame
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BraidController : MonoBehaviour
    {
        //public 
        [Range(1, 5)] 
        public float ForceJump = 4; // req = 4

        [Range(1, 5)] 
        public float SpeedWalk = 3; //req = 3
        
        //private
        private Rigidbody2D _rigid;

        private Vector3 _startPos;
        private SpriteRenderer _spriteRenderer;
        private Animator _animator;
        
        private void Awake()
        {
            _rigid = GetComponent<Rigidbody2D>();
            _startPos = transform.position;
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _animator = GetComponent<Animator>();
        }

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            
            _animator.SetFloat("speed", Mathf.Abs(h)*2.2f);
            if (h<0)
            {
                _spriteRenderer.flipX = true;
            }
            if (h>0)
            {
                _spriteRenderer.flipX = false;
            }

            _rigid.velocity = new Vector2(h * SpeedWalk, _rigid.velocity.y);

            if (Input.GetButtonDown("Jump"))
            {
                _animator.SetTrigger("jump");
                _rigid.velocity = new Vector2(_rigid.velocity.x, 0);
                _rigid.AddForce(Vector2.up * ForceJump, ForceMode2D.Impulse);
            }


            // Debug.Log(h + " - " + v);
        }


        public void ResetPosition()
        {
            transform.position = _startPos;
        }
    }
}