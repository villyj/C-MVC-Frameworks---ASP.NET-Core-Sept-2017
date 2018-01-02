using System.Collections.Generic;
using SciBoard.Entities;

namespace SciBoard.Services
{
   public interface IMaterialData
    {
        IEnumerable<Material> GetAll();

        Material Get(int id);

    }
}
