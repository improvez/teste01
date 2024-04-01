using System.Linq;
using System.Threading.Tasks;

namespace _teste01.Models {
    public class Funcionario
{
    public int Matricula { get; set; }
    public DateTime DataNascimento { get; set; }
    public string EstadoCivil { get; set; }
    public string Endereco { get; set; }
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public string RG { get; set; }
    public char Sexo { get; set; }
    public string CIC { get; set; }
    public DateTime DataAdmissao { get; set; }
    public string Telefone { get; set; }
    public List<Cargo> CargosOcupados { get; set; }
    public List<Departamento> DepartamentosLotacao { get; set; }
    public List<Dependente> Dependentes { get; set; }
}
    
}