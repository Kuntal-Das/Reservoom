using System;

namespace Models
{
    public class RoomID
    {
        /// <summary>
        /// Floor Number of the RoomID
        /// </summary>
        public int FloorNumber { get; }
        /// <summary>
        /// RoomNumber of the RoomID
        /// </summary>
        public int RoomNumber { get; }

        /// <summary>
        /// Create RoomID object
        /// </summary>
        /// <param name="floorNumber"></param>
        /// <param name="roomNumber"></param>
        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override bool Equals(object? obj)
        {
            if (obj is RoomID roomId)
            {
                return FloorNumber == roomId.FloorNumber && RoomNumber == roomId.RoomNumber;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public override string? ToString()
        {
            return $"{FloorNumber}-{RoomNumber}";
        }

        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 is null && roomID2 is null) return true;

            return roomID1 is not null && roomID1.Equals(roomID2);
        }

        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }
    }
}