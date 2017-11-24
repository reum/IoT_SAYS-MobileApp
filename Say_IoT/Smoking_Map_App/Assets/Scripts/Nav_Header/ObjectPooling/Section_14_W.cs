using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section_14_W : PoolableObject
{

    [HideInInspector] public Transform tm;
    [HideInInspector] public Rigidbody2D rb2D;

    public int ras_1_ppm;
    SpriteRenderer render;


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
        render = GetComponent<SpriteRenderer>();

        // Up_Speed = 3.0f;

    }

    void Update()
    {
        Get_Upgrade_PPM();
    }

    void OnEnable()
    {
        _OnEnableContents();
    }

    void OnDisable()
    {
        _OnDisableContents();
    }

    public void Get_Upgrade_PPM()
    {
        ras_1_ppm = PlayerPrefs.GetInt("ras_1_ppm");
    }

    void CheckPPM()
    {
        if(ras_1_ppm >= 99)
        {
            render.color = new Color(220, 10, 10, 1);
        }else if (ras_1_ppm < 99 && ras_1_ppm >= 49)
        {
            render.color = new Color(200, 220, 10, 1);

        }
        else
        {
            render.color = new Color(90, 220, 40, 1);
        }
        //render.color = new Color(1, 1, 1, 1); //색상은 흰색에 Alpa 값은 1(화면에 나타남.)
                                              // Alpa에 0을 넣으면 나타나지 않습니다

        
    }
}
