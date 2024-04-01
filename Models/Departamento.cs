using System.Linq;
using System.Threading.Tasks;

namespace _teste01.Models {
    public class Departamento
{
    public int ID { get; set; }
    public string NomeDepartamento { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
}

}