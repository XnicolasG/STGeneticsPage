using STGeneticsPage.DBModel;

namespace STGeneticsPage.Data
{
    public interface CRUDAnimals
    {
        Task<IEnumerable<Animals>> GetAllData();
        Task<Animals> GetAnimalsDtl(int id);
        Task<bool> LoadAnimal (Animals animals);
        Task<bool> UpdateAnimal(Animals animals);
        Task<bool> DeleteAnimal(int id);
        Task<bool> SaveAnimal (Animals animals);
    }
}
