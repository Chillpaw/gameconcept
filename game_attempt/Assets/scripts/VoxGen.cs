using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class VoxGen : MonoBehaviour
{
    public GameObject block;
    [Range (0,100)]
    public int width;
    [Range(0, 100)]
    public int height;
    [Range(0, 100)]
    public int depth;

    private Transform landscape;

    void Start()
    {
        GenerateWorld();
    }
    
    bool Init()
    {
        return true;
    }
    void GenerateWorld()
    {
        landscape = new GameObject("landscape").transform;

        for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
                for (int z = 0; z < depth; z++)
                {
                    //block.GetComponent<Renderer>().material.color = new Color(1,2,3);
                    PickBlock(x,y,z);
                }
        
    }

    void PickBlock(int xPos,int yPos,int zPos)
    {
        Instantiate(block, new Vector3(xPos, yPos, zPos), Quaternion.identity);
        block.transform.SetParent(landscape);
    }
}
