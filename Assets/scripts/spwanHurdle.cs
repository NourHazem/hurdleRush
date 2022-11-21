using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanHurdle : MonoBehaviour
{
    public GameObject hurdle;
    private Vector3 hurdlepos;
    private float timer;
    private float delay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        enmeySpwan();
    }
    void enmeySpwan()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            hurdlepos = new Vector3(Random.Range(-6f, 6f), transform.position.y, transform.position.z);
            Instantiate(hurdle, hurdlepos, Quaternion.identity);
            timer = delay;
        }
    }
}
