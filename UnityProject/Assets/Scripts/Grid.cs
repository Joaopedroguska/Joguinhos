using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid {

    private int largura, altura;
    private float tamanhoCelula;
    private Vector3 posicaoOrigem;
    private int[,] gridArray;
    private TextMesh[,] debugTextArray;

    public Grid(int largura, int altura, float tamanhoCelula, Vector3 posicaoOrigem) {
        this.largura = largura;
        this.altura = altura;
        this.tamanhoCelula = tamanhoCelula;
        this.posicaoOrigem = posicaoOrigem;

        gridArray = new int[largura, altura];
        debugTextArray = new TextMesh[largura, altura];
        //int z = 0;
        for (int x = 0; x < gridArray.GetLength(0); x++) {
            for (int y = 0; y < gridArray.GetLength(1); y++) {
                debugTextArray[x, y] = UtilsClass.CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y) + new Vector3(tamanhoCelula, tamanhoCelula) * .5f, 20, Color.white, TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 100f);
                
                //setValue(x, y, z);
                //z++;
            }      
        }
        Debug.DrawLine(GetWorldPosition(0, altura), GetWorldPosition(largura, altura), Color.white, 100f);
        Debug.DrawLine(GetWorldPosition(largura, 0), GetWorldPosition(largura, altura), Color.white, 100f);

        
    }

    private Vector3 GetWorldPosition(int x, int z)
    {
        return new Vector3(x, 0, z) * tamanhoCelula + posicaoOrigem;
    }

    private void getXZ(Vector3 worldPosition, out int x, out int z)
    {
        x = Mathf.FloorToInt((worldPosition - posicaoOrigem).x / tamanhoCelula);
        z = Mathf.FloorToInt((worldPosition - posicaoOrigem).z / tamanhoCelula);
    }

    public void setValue(int x, int y, int value) {
        if (x >= 0 && y >= 0 && x < largura && y < altura) {
            gridArray[x, y] = value;
            debugTextArray[x, y].text = gridArray[x, y].ToString();
        }
    }
    
    public void setValue(Vector3 worldPosition, int value)
    {
        int x, z;
        getXZ(worldPosition, out x, out z);
        setValue(x, z, value);
    }

    public int getValue(int x, int z)
    {
        if(x >= 0 && z >= 0 && x < largura && z < altura){
            return gridArray[x, z];
        }else{
            return 0;
        }
    }

    public int getValue(Vector3 worldPosition)
    {
        int x, z;
        getXZ(worldPosition, out x, out z);
        return getValue(x, z);
    }
}
