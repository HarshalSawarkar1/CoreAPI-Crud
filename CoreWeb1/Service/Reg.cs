using CoreWeb1.Models;
using System.Collections.Generic;
//using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CoreWeb1.Service
{
    public class Reg : IReg
    {
        private readonly FirstMVCContext _FirstMVCContext;
        public Reg(FirstMVCContext FirstMVCContext) 
        {
            _FirstMVCContext = FirstMVCContext;
        }
        public async Task<IEnumerable<TblReg>> GetRegList()
        {
            var regList = await _FirstMVCContext.TblReg.ToListAsync();
            return regList;
        }
        public async Task<TblReg> DeleteReg(int Id) 
        {
            var result = await _FirstMVCContext.TblReg.FirstOrDefaultAsync(x => x.Id == Id);
            if (result == null)
            {
                return null;
            }
            _FirstMVCContext.TblReg.Remove(result);
            await _FirstMVCContext.SaveChangesAsync();
            return result;
        }
        public async Task<TblReg> AddReg(TblReg Reg)
        {
            _FirstMVCContext.TblReg.Add(Reg);
            await _FirstMVCContext.SaveChangesAsync();
            return Reg;
        }
        public async Task<TblReg> UpdateReg(TblReg Reg)
        {
            _FirstMVCContext.Entry(Reg).State = EntityState.Modified;
            await _FirstMVCContext.SaveChangesAsync();
            return Reg;
        }
    }
}
