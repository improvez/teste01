using System.Linq;
using System.Threading.Tasks;

namespace _teste01.Models {
    public class Cargo
{
    public int ID { get; set; }
    public string NomeCargo { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
} 

}