using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int DestX;
    [SerializeField] int DestY;

    Vector2 North; 

    Grid grid;

    Rigidbody2D dwarfBody;

    void Start()
    {
        grid = GameObject.Find("Ground").GetComponent<Grid>();
        dwarfBody = GetComponent<Rigidbody2D>();
        North = new Vector2(0, grid.cellSize.y / 100);
    }

    // Update is called once per frame
    void Update()
    {
        dwarfBody.position += dwarfBody.position + North;
    }
}
