using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nav_Move : MonoBehaviour {

    [HideInInspector] public RectTransform tm;
    [HideInInspector] public Rigidbody2D rb2D;


    private static Nav_Move singleton;
    public static Nav_Move instance;   //싱글톤 패턴



    private float Speed;
    public Vector3 Position;
    public float OriPos;

   
    void Awake()
    {

        if (singleton != null && singleton != this)
        {
            Destroy(gameObject);
        }
        else
        {
            singleton = this;
            DontDestroyOnLoad(this);

        }

        Nav_Move.instance = this;  //변수 초기화부  다른 스크립트에서 이 스크립트 함수를 사용 가능하게 만든다// 

        tm = GetComponent<RectTransform>();
        Speed = 50000;
        Position = tm.position;
        OriPos = -16500;


    }

    void Start()
    {
        Position.x = OriPos;
    }

    
	// Update is called once per frame
	void Update () {


   

        if (tm.position.x < 0.0f )
        {
            Position.x += Speed * Time.fixedDeltaTime;
            tm.position = Position;
        }
        else if (tm.position.x >= 0.0f)
        {
            // Speed = 0.0f;
            Position.x = 0.0f;
            tm.position = Position;

        }

      

    }

  


}
