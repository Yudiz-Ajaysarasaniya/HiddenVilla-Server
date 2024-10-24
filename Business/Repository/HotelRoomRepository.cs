using Business.Repository.IRepository;
using DataAccess.Data;
using DataAccess.Data.Entities;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly AppDbContext dbContext;

        public HotelRoomRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<HotelRoom> CheckRoomExist(string name)
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoom> CreateHotelRoom(HotelRoomDTO hotelRoomDTO)
        {

            throw new NotImplementedException();
        }

        public Task<IEnumerable<HotelRoom>> GetAllHotelRooms()
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoom> GetHotelRoom(int roomId)
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoom> UpdateHotelRoom(int roomId, HotelRoomDTO hotelRoomDTO)
        {
            throw new NotImplementedException();
        }
    }
}
