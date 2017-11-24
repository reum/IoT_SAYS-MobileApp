using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section_11_W : PoolableObject
{

    [HideInInspector]
    public Transform tm;
    [HideInInspector]
    public Rigidbody2D rb2D;

    // private float Up_Speed;
    //public float OriCont;

    public override void Create(ObjectPool<PoolableObject> pool)
    {
        base.Create(pool);
    }

    public override void Dispose()
    {
        base.Dispose();
    }

    public override void _OnEnableContents()
    {
        base._OnEnableContents();

        rb2D.Sleep();
    }

    public override void _OnDisableContents()
    {
        base._OnDisableContents();
    }

    void Awake()
    {
        tm = gameObject.GetComponent<Transform>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();

        // Up_Speed = 3.0f;

    }

    void Update()
    {

    }

    void OnEnable()
    {
        _OnEnableContents();
    }

    void OnDisable()
    {
        _OnDisableContents();
    }
}
