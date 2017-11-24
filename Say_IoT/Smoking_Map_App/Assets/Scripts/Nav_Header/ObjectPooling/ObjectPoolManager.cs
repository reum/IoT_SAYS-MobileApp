// ObjectPoolManager.cs
using UnityEngine;
using System.Collections;

public class ObjectPoolManager : MonoBehaviour 
{
    private static ObjectPoolManager singleton;
    public static ObjectPoolManager GetInstance() { return singleton; }

    public ObjectPool<PoolableObject> Nav_Headerpool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_1_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_2_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_3_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_4_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_5_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_6_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_7_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_8_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_9_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_10_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_11_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_12_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_13_pool = new ObjectPool<PoolableObject>();
    public ObjectPool<PoolableObject> Section_14_pool = new ObjectPool<PoolableObject>();


    public Nav_Header Nav_Headerprefab;
    public Section_1_W Section_1_Headerprefab;
    public Section_2_W Section_2_Headerprefab;
    public Section_3_W Section_3_Headerprefab;
    public Section_4_W Section_4_Headerprefab;
    public Section_5_W Section_5_Headerprefab;
    public Section_6_W Section_6_Headerprefab;
    public Section_7_W Section_7_Headerprefab;
    public Section_8_W Section_8_Headerprefab;
    public Section_9_W Section_9_Headerprefab;
    public Section_10_W Section_10_Headerprefab;
    public Section_11_W Section_11_Headerprefab;
    public Section_12_W Section_12_Headerprefab;
    public Section_13_W Section_13_Headerprefab;
    public Section_14_W Section_14_Headerprefab;




    void Awake()
    {
        if (singleton != null && singleton != this)
        {
            Destroy(gameObject);
        }
        else
        {
            singleton = this;
        }
    }

    void Start()
    {
        Nav_Headerpool = new ObjectPool<PoolableObject>(1, () =>
        {
            Nav_Header Nav_Header = Instantiate(Nav_Headerprefab);
            Nav_Header.Create(Nav_Headerpool);
            return Nav_Header;
        });

        Nav_Headerpool.Allocate();

        Section_1_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_1_W Section_1_W = Instantiate(Section_1_Headerprefab);
            Section_1_W.Create(Section_1_pool);
            return Section_1_W;
        });

        Section_1_pool.Allocate();

        Section_2_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_2_W Section_2_W = Instantiate(Section_2_Headerprefab);
            Section_2_W.Create(Section_2_pool);
            return Section_2_W;
        });

        Section_2_pool.Allocate();

        Section_3_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_3_W Section_3_W = Instantiate(Section_3_Headerprefab);
            Section_3_W.Create(Section_3_pool);
            return Section_3_W;
        });

        Section_3_pool.Allocate();

        Section_4_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_4_W Section_4_W = Instantiate(Section_4_Headerprefab);
            Section_4_W.Create(Section_4_pool);
            return Section_4_W;
        });

        Section_4_pool.Allocate();

        Section_5_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_5_W Section_5_W = Instantiate(Section_5_Headerprefab);
            Section_5_W.Create(Section_5_pool);
            return Section_5_W;
        });

        Section_5_pool.Allocate();

        Section_6_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_6_W Section_6_W = Instantiate(Section_6_Headerprefab);
            Section_6_W.Create(Section_6_pool);
            return Section_6_W;
        });

        Section_6_pool.Allocate();

        Section_7_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_7_W Section_7_W = Instantiate(Section_7_Headerprefab);
            Section_7_W.Create(Section_7_pool);
            return Section_7_W;
        });

        Section_7_pool.Allocate();

        Section_8_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_8_W Section_8_W = Instantiate(Section_8_Headerprefab);
            Section_8_W.Create(Section_8_pool);
            return Section_8_W;
        });

        Section_8_pool.Allocate();

        Section_9_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_9_W Section_9_W = Instantiate(Section_9_Headerprefab);
            Section_9_W.Create(Section_9_pool);
            return Section_9_W;
        });

        Section_9_pool.Allocate();

        Section_10_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_10_W Section_10_W = Instantiate(Section_10_Headerprefab);
            Section_10_W.Create(Section_10_pool);
            return Section_10_W;
        });

        Section_10_pool.Allocate();

        Section_11_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_11_W Section_11_W = Instantiate(Section_11_Headerprefab);
            Section_11_W.Create(Section_11_pool);
            return Section_11_W;
        });

        Section_11_pool.Allocate();

        Section_12_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_12_W Section_12_W = Instantiate(Section_12_Headerprefab);
            Section_12_W.Create(Section_12_pool);
            return Section_12_W;
        });

        Section_12_pool.Allocate();

        Section_13_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_13_W Section_13_W = Instantiate(Section_13_Headerprefab);
            Section_13_W.Create(Section_13_pool);
            return Section_13_W;
        });

        Section_13_pool.Allocate();

        Section_14_pool = new ObjectPool<PoolableObject>(1, () =>
        {
            Section_14_W Section_14_W = Instantiate(Section_14_Headerprefab);
            Section_14_W.Create(Section_14_pool);
            return Section_14_W;
        });

        Section_14_pool.Allocate();
    }

    void OnDestroy()
    {
        Nav_Headerpool.Dispose();
        Section_1_pool.Dispose();
        Section_2_pool.Dispose();
        Section_3_pool.Dispose();
        Section_4_pool.Dispose();
        Section_5_pool.Dispose();
        Section_6_pool.Dispose();
        Section_7_pool.Dispose();
        Section_8_pool.Dispose();
        Section_9_pool.Dispose();
        Section_10_pool.Dispose();
        Section_11_pool.Dispose();
        Section_12_pool.Dispose();
        Section_13_pool.Dispose();
        Section_14_pool.Dispose();
        singleton = null;
    }

}
