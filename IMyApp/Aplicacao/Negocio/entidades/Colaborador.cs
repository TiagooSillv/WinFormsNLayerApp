using Negocio.comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.entidades
{
    public class Colaborador : Pessoa
    {
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }


        public Colaborador ( string nome,
                            string telefone,
                            DateTime nascimento,
                            string genero,
                            string cpf,
                            string rg,
                            bool status,
                            DateTime criadoEm,
                            string criadoPor,
                            DateTime alteradoEm,
                            string alteradoPor,
                            string enderecoEstado,
                            string enderecoCidade,
                            string enderecoBairro,
                            string enderecoRua,
                            string enderecoNumero,
                            string nacionalidade,
                            string estadoCivil,
                            DateTime dataAdmissao) 
                        
        {
            nome = Nome;
            telefone = Telefone;
            genero = Genero;
            cpf = Cpf;
            rg = Rg;
            status = Status;
            nascimento = Nascimento;
            rg = Rg;
            criadoEm = CriadoEm;
            criadoPor = CriadoPor;
            alteradoEm = AlteradoEm;
            alteradoPor = AlteradoPor;
            enderecoEstado = EnderecoEstado;
            enderecoCidade = EnderecoCidade;
            enderecoBairro = EnderecoBairro;
            enderecoRua = EnderecoRua;
            enderecoNumero = EnderecoNumero;
            estadoCivil = EstadoCivil;
            nacionalidade = Nacionalidade;
            dataAdmissao = DataAdmissao;
        }
    }
}
