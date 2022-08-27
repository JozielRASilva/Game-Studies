using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jozi.GameLibrary.Core.Tileset
{
    public class GridManager : MonoBehaviour
    {
        public Transform Center;

        public int Height = 32, Width = 32, Depth = 32;

        public Vector3 TileSize = new Vector3(1, 1, 1);

        public GameObject TilePrefab;

        private void Start()
        {
            GenerateGrid();
        }

        private void GenerateGrid()
        {
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    for (int d = 0; d < Depth; d++)
                    {
                        CreateTile(h, w, d);
                    }
                }
            }
        }


        private void CreateTile(int heithIndex, int widthIndex, int depthIndex)
        {
            if (!TilePrefab || !Center)
                return;
            Vector3 position = new Vector3(Center.position.x + widthIndex, Center.position.y + heithIndex, Center.position.z + depthIndex);

            Instantiate(TilePrefab, position, Quaternion.identity, transform);
        }


    }
}