using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    private Grid grid;

    // Start is called before the first frame update
    private void Start()
    {
        grid = new Grid(5, 5, 10f, new Vector3(-16,0,0));
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.setValue(UtilsClass.GetMouseWorldPosition(), 56);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.getValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
