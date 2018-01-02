using System.Collections.Generic;
using System.Linq;
using SciBoard.Entities;

namespace SciBoard.Services
{
    public class MockMaterialData : IMaterialData

    {
        private List<Material> _materials;
        public MockMaterialData()
        {
            _materials = new List<Material>
            {
                new Material { Id = 1, GenreId=1,  Title = "Shreck" }, 
                new Material { Id = 2, GenreId=2, Title = "Despicable Me" },
                new Material { Id = 3, GenreId=3, Title = "Megamind" }
            };
        }

        public IEnumerable<Material> GetAll()
        {
            return _materials;
        }

        public Material Get(int id)
        {
            return _materials.FirstOrDefault(v => v.Id.Equals(id));
        }

    }
    
}
