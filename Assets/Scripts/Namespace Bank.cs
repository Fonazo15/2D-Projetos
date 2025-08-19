using UnityEngine;

namespace Game
{
    public class MeasurementSystem
    {
        private readonly float ConversionRate = 0.01f;
        public float ApplyMesures(float abstractValues)
        {
            return ConversionRate * abstractValues;
        }
    }
    public class Board
    {
        public Vector2 BoardSize { get { return new Vector2(10f, 0f); } } // Use Measurement System to apply actual size
        private Tile[] Tiles()
        {
            return new Tile[Mathf.FloorToInt(Mathf.Abs(BoardSize.x) * Mathf.Abs(BoardSize.y))];
        }
        //public Board() { }
    }
    public class Tile
    {
        public static Vector2 TileSize = new Vector2(5,5);
    }
}
