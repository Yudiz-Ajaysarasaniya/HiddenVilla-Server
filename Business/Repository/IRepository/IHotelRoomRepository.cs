using DataAccess.Data.Entities;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoom> CreateHotelRoom(HotelRoomDTO hotelRoomDTO);
        public Task<HotelRoom> UpdateHotelRoom(int roomId, HotelRoomDTO hotelRoomDTO);
        public Task<HotelRoom> GetHotelRoom(int roomId);
        public Task<IEnumerable<HotelRoom>> GetAllHotelRooms();
        public Task<HotelRoom> CheckRoomExist(string name);
    }
}
