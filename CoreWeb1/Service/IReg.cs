using System.Collections.Generic;
using System.Threading.Tasks;
using CoreWeb1.Models;
using System.Linq;

namespace CoreWeb1.Service
{
    public interface IReg
    {
        Task<IEnumerable<TblReg>> GetRegList();
        Task<TblReg> DeleteReg(int Id);
        Task<TblReg> AddReg(TblReg Reg);
        Task<TblReg> UpdateReg(TblReg Reg);
    }
}
        