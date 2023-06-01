using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator _animator;
    private Vector3 charPos;
    private SpriteRenderer _spriteRenderer;
    [SerializeField] private GameObject _camera;
    private int sayi;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        r2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        charPos = transform.position;
        sayi = 1;
    }

    private void FixedUpdate() //fizik hesaplamalar� bu k�s�mda yap�l�r.�uanda50kere yap�cak
    {
        //Debug.Log("Fixed"+sayi);
        sayi = 2;
        // r2d.velocity = new Vector2(x: speed, y: 0f);
    }



    void Update()
    {

        charPos = new Vector3(x: charPos.x + (Input.GetAxis("Horizontal") * speed * Time.deltaTime), charPos.y);
        transform.position = charPos;//hesaplan�lan pozifyon karaktere i�lensin
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat("speed", value: 0.0f);
        }

        else
        {
            _animator.SetFloat("speed", value: 1.0f);

        }

        if (Input.GetAxis("Horizontal") > 0.01f)
        {
            _spriteRenderer.flipX = false;
        }

        else if (Input.GetAxis("Horizontal") < -0.01f)
        {
            _spriteRenderer.flipX = true;
        }
           
            sayi = 3;
            Debug.Log("Update" + sayi);
    }

    private void LateUpdate()
    {
        sayi=4;
        //_camera.transform.position = new Vector3(charPos.x, y:charPos.y,z:charPos.z - 1.0f);//kemaran�n karakterden uzakla�mas�n� sa�l�yor.
    }


}
