using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;

public class RoomPlacer : MonoBehaviour
{
    public Room[] roomPrefabs;
    public Room startingRoom;

    private Room[,] _spawnedRooms;

    private IEnumerator Start()
    {
        _spawnedRooms = new Room[5, 5];
        _spawnedRooms[1, 1] = startingRoom;
        for (int i = 0; i < 12; i++)
        {
            PlaceOneRoom();
            yield return new WaitForSecondsRealtime(0.5f);
        }

    }
    private void PlaceOneRoom()
    {
        HashSet<Vector2Int> vacantPlaces = new HashSet<Vector2Int>();
        for (int x = 0; x < _spawnedRooms.GetLength(0); x++)
        {
            for (int y = 0; y < _spawnedRooms.GetLength(1); y++)
            {
                if (_spawnedRooms[x, y] == null) continue;

                int maxX = _spawnedRooms.GetLength(0) - 1;
                int maxY = _spawnedRooms.GetLength(1) - 1;

                if (x > 0 && _spawnedRooms[x - 1, y] == null) vacantPlaces.Add(new Vector2Int(x - 1, y));
                if (y > 0 && _spawnedRooms[x, y - 1] == null) vacantPlaces.Add(new Vector2Int(x, y - 1));
                if (x < maxX && _spawnedRooms[x + 1, y] == null) vacantPlaces.Add(new Vector2Int(x + 1, y));
                if (y < maxY && _spawnedRooms[x, y + 1] == null) vacantPlaces.Add(new Vector2Int(x, y + 1));



            }
        }
        Room newRoom = Instantiate(roomPrefabs[Random.Range(0, roomPrefabs.Length)]);
        newRoom.RotateRandomly();
        Vector2Int position = vacantPlaces.ElementAt(Random.Range(0, vacantPlaces.Count));
        newRoom.transform.position = new Vector3(position.x - 3, 0, position.y - 3) * 35f;

        _spawnedRooms[position.x, position.y] = newRoom;
    }
}