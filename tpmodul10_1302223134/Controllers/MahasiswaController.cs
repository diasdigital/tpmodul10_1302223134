using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223134.Controllers
{
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Dias Adani", "1302223134"),
            new Mahasiswa("Iksan Oktav Risandy", "1302223042"),
            new Mahasiswa("Fauzein Mulya Warman", "1302223127"),
            new Mahasiswa("Muhammad Haulul Azkiyaa", "1302223007"),
            new Mahasiswa("Muhammad Nur Shodiq", "1302223054"),
            new Mahasiswa("Muhammad Fathan Akram", "1302223026")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            dataMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
