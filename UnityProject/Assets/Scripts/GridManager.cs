/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridManager : MonoBehaviour
{
    private int linhas = 5, colunas = 8;
    private float tileSize = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        generateGrid();
    }

    private void generateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("tile"));
        for (int linha = 0; linha < linhas; ++linha)
        {
            for (int coluna = 0; coluna < colunas; ++coluna)
            {
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);

                float posX = coluna * tileSize;
                float posZ = linha * -tileSize;

                tile.transform.position = new Vector3(posX, 0, posZ);
            }
        }

        Destroy(referenceTile);
    }

    // Update is called once per frame
    void Update()
    {

    }


}*/