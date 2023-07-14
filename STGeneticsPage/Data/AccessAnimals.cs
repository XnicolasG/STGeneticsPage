using Microsoft.EntityFrameworkCore;
using STGeneticsPage.DBModel;

namespace STGeneticsPage.Data
{
    public class AccessAnimals : CRUDAnimals
    {
        private readonly AnimalContext _context; //creating a private readonly variable
        public AccessAnimals(AnimalContext context) //constructor
        {
            _context = context; //global context == local context
        }
        public async Task<bool> DeleteAnimal(int id)
        {
            var animal = await _context.AnimalsT.FindAsync(id); // this line will find in DbSet AnimalsT
            _context.AnimalsT.Remove(animal); // once entity find it will be delete it
            return await _context.SaveChangesAsync() > 0; //needs to be greater than 0 to be true (Successful)
        }

        public async Task<IEnumerable<Animals>> GetAllData()
        {
            return await _context.AnimalsT.ToListAsync(); //will list everything in AnimalsT
        }

        public async Task<Animals> GetAnimalsDtl(int id)
        {
            return await _context.AnimalsT.FindAsync(id);
        }

        public async Task<bool> LoadAnimal(Animals animals)
        {
            _context.AnimalsT.Add(animals); 
            return await _context.SaveChangesAsync() > 0; //needs to be greater than 0 to be true (Successful)
        }

        public async Task<bool> SaveAnimal(Animals animals) //this is created to delegate the service to choose when it's an update abd when is a an insert(load)
        {
            if (animals.AnimalId.Length >0)  
            {
                return await UpdateAnimal(animals);
            }
            else
            {
                return await LoadAnimal(animals);
            }
        }

        public async Task<bool> UpdateAnimal(Animals animals)
        {
            
            _context.Entry(animals).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0; //needs to be greater than 0 to be true (Successful)

        }
    }
}
